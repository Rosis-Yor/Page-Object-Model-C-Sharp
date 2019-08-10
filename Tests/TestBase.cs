using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageOModel;

namespace Tests
{
    [TestClass]
    public class TestBase

    {
        [TestInitialize]
        public void TestMethod1()
        {

            Browser.Initialize();
        }

        [TestCleanup]
        public void SayGoodBye() {

            Console.WriteLine(" Done with distinction ! ");
        }
    }
}
