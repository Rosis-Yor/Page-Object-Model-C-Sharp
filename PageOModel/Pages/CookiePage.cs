using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageOModel.Pages
{
    public class CookiePage
    {
        IWebElement acceptCookie
        {
            get { return Browser.Driver.FindElement(By.Name("agree")); }
        }

        public void acceptCokie() {

            Browser.Driver.FindElement(By.Name("agree")).Click();
        }
    }
}
