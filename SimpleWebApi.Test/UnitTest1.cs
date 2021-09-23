using NUnit.Framework;
using SimpleWebAPI.Controllers;

namespace SimpleWebAPI.Test
{
    public class Tests
    {
        private readonly SimpleWebAPI.Controllers.ValuesController c = new ValuesController();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void GetMyNameTest()
        {

            var returnValue = c.Get(1);
            Assert.AreEqual("Paul Roberts", returnValue);

        }
    }
}