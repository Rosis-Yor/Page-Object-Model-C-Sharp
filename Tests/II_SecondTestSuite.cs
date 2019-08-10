using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageOModel.Pages;
using PageOModel;
using System.Threading;

namespace Tests
{
    [TestClass]
    public class II_SecondTestSuite : TestBase
    {
        [TestMethod]
        public void GoToHome()
        {

            Pages.CookieAccept.acceptCokie();
            string title = Browser.Title;

            Console.WriteLine(title);
            Assert.AreEqual(Browser.Title, "Yahoo");
        }

        [TestMethod]
        public void reachLogin() {

            Pages.CookieAccept.acceptCokie();
            Pages.LatestNews.toLoginPage();
            
            Assert.IsTrue(Browser.Title.Contains("login"));
        }

        [TestMethod]
        public void errorPresence() {

            Pages.CookieAccept.acceptCokie();
            Pages.LatestNews.toLoginPage();
            Pages.EnterPrivate.enterMail("rosi@rosi.com");
            Pages.EnterPrivate.submitMail();
           // Thread.Sleep(5000);
            //Assert.IsTrue(Pages.EnterPrivate.isDisplayed());

            Assert.IsTrue(Pages.EnterPrivate.isOnPage());

        }
    }
}
