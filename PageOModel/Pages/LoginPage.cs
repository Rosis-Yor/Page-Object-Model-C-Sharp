using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageOModel.Pages
{
    public class LoginPage
    {

        public void enterMail(string mailName)
        {

            Browser.Driver.FindElement(By.CssSelector("input#login-username")).SendKeys(mailName);
        }

        public void submitMail()
        {

            Browser.Driver.FindElement(By.CssSelector("input#login-signin")).Click();
        }

        public bool isDisplayed()
        {
            IWebElement userError = Browser.Driver.FindElement(By.CssSelector("#username-error"));

            return userError.Displayed;
        }

        public bool isOnPage()
        {


            By userError = By.CssSelector("#username-error");

            try
            {
                WebDriverWait wdw = new WebDriverWait((IWebDriver)Browser.Driver, TimeSpan.FromSeconds(5));
                wdw.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(userError));

                return Browser.Driver.FindElement(userError).Displayed;
            }
            catch (NoSuchElementException e) {

                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
    }
}
