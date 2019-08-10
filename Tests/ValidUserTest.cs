using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestClass]
    public class ValidUserTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver dr = new ChromeDriver();
            string url = "http://www.yahoo.com";

            dr.Navigate().GoToUrl(url);

        }
    }
}
