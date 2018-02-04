using NUnit.Framework;
using System;
namespace InMemoryLoaderBase.UnitTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {

            var key = AbstractComponent.Key;


            Assert.IsNotNull(key);
        }
    }
}
