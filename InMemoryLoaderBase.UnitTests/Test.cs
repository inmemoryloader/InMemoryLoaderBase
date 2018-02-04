using System.Configuration;
using NUnit.Framework;

namespace InMemoryLoaderBase.UnitTests
{
    /// <summary>
    /// InMemoryLoaderBase test cases
    /// </summary>
    [TestFixture()]
    public class Test
    {

        string ApplicationKey => ConfigurationManager.AppSettings["ApplicationKey"];

        /// <summary>
        /// AbstractComponent test
        /// </summary>
        [Test()]
        public void AbstractComponentTest()
        {
            var component = new AbstractComponentHelper();
            var key = AbstractComponent.Key;

            var init_1 = component.Init(key);
            var init_2 = component.Init(ApplicationKey);

            Assert.IsTrue(init_1);
            Assert.IsTrue(init_2);
            Assert.AreEqual(ApplicationKey, key);
        }




    }

}
