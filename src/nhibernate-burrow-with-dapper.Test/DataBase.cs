using NHibernate.Burrow.Util;
using NUnit.Framework;

namespace CibaVision.Test
{
    [TestFixture, Explicit]
    public class DataBase
    {
        [Test, Explicit]
        public void CreateDB()
        {
            new SchemaUtil().CreateSchemas();
        }
        [Test, Explicit]
        public void UpdateDB()
        {
            new SchemaUtil().UpdateSchemas(true, true);
        }
    }
}