using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;

namespace Tests
{
    [TestClass]
    public class I_FirstTestSuite

    {

        string url = "http://www.yahoo.com";
        IWebDriver drv = new FirefoxDriver();

        [TestInitialize]
        public void initialize() { 
         
             drv.Navigate().GoToUrl(url);

          //   return drv;
        
        }

      

        [TestMethod]
        public void LandingPage()
        {

           
           drv.FindElement(By.Name("agree")).Click();
             
        }

        [TestMethod]
        public void HomePage() {

            drv.FindElement(By.Name("agree")).Click();

            drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            drv.FindElement(By.CssSelector("#uh-signin")).Click();
           // Thread.Sleep(3000);
           string Title = drv.Title;
         NUnit.Framework.Assert.AreEqual("Yahoo - login", Title);
          
        }

        [TestMethod]
        public void LoginPage()
        {

            drv.FindElement(By.Name("agree")).Click();

            drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            drv.FindElement(By.CssSelector("#uh-signin")).Click();
            // Thread.Sleep(3000);
            drv.FindElement(By.CssSelector("input#login-username")).SendKeys("rosi@rosi.com");
           

            string btnValue = drv.FindElement(By.CssSelector("input#login-signin")).GetAttribute("value");
            Console.WriteLine(btnValue);
            Thread.Sleep(5000);
            IWebElement btnNext = drv.FindElement(By.CssSelector("input#login-signin"));
           
            btnNext.Click();
            Thread.Sleep(5000);
            IWebElement userError = drv.FindElement(By.CssSelector("#username-error") );
            string msg = userError.Text;
            Console.WriteLine(msg);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(userError.Displayed);



        }
    }
}