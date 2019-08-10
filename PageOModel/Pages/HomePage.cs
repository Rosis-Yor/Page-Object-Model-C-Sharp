using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageOModel.Pages
{
    public class HomePage
    {

       public void toLoginPage() {
       
           Browser.Driver.FindElement(By.CssSelector("#uh-signin")).Click();
       }
    }
}
