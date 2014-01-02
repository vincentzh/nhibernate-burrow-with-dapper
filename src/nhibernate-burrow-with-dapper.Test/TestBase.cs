using log4net.Config;
using NHibernate.Burrow;
using NUnit.Framework;

namespace CibaVision.Test
{
    public abstract class TestBase
    {
        protected BurrowFramework Burrow = new BurrowFramework();

        [SetUp]
        public virtual void Setup()
        {
            XmlConfigurator.Configure();
            Burrow.InitWorkSpace();
        }

        protected void Flush()
        {
            Burrow.GetSession().Flush();
        }


        [TearDown]
        public virtual void TearDown()
        {
            Burrow.CloseWorkSpace();
        }
    }
}