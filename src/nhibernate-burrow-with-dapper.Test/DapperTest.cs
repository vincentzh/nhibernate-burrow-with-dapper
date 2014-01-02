using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CibaVision.Test;
using Dapper;
using NHibernate.Util;
using NUnit.Framework;

namespace nhibernate_burrow_with_dapper.Test
{
    [TestFixture]
    public class DapperTest : TestBase
    {
        [Test]
        public void ReadData()

        {
            using (
                var sqlConnection =
                    new SqlConnection(
                        Burrow.BurrowEnvironment.Configuration.
                            DBConnectionString(typeof (Brand))))
            {
                sqlConnection.Open();
                var brands =
                    sqlConnection.Query<Brand>("Select * from tblBrands where Id=@Id",new{Id=1});
                foreach (var brand in brands)
                {
                     Assert.IsFalse(Burrow.GetSession().Contains(brand));
                 
                    Console.WriteLine(brand);
                    brand.Name = "Test13";
                }
                //var brand2=Burrow.GetSession().Get<Brand>(1);
                //brand2.Name = "Test12";
                Burrow.GetSession().Update(brands.First());
                //Burrow.CloseWorkSpace();
                //Burrow.InitWorkSpace();
                Burrow.GetSession().Merge(brands.FirstOrNull());
                var brand3 = Burrow.GetSession().Get<Brand>(1);
               // Assert.AreEqual(brand2.Name,brand3.Name);
                Assert.AreEqual(brands.First().Name,brand3.Name);
            }
           
        }

        [Test]
        public void InsertData()
        {
            using (
              var sqlConnection =
                  new SqlConnection(
                      Burrow.BurrowEnvironment.Configuration.
                          DBConnectionString(typeof(Brand))))
            {
                var brand = new Brand()
                            {
                                Name = "Test1",
                                Abbrev = "Test1",
                                IsDisabled = false
                            };
                sqlConnection.Open();
                 brand.Id =
                    sqlConnection.Query<int>(@"insert tblBrands(Name, Abbrev,IsDisabled)
                            values (@Name, @Abbrev,@IsDisabled)
                            select cast(scope_identity() as int)", brand).First();
              
                    Console.WriteLine(brand.Id);
            
            }
        }
    }
}