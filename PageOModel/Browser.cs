using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOModel
{
    public static class Browser
    {

        private static IWebDriver _dr = new FirefoxDriver();
        private static string _baseUrl = "http://www.yahoo.com";

        public static ISearchContext Driver {

            get { return _dr; }
        }

        public static string Title { get { return _dr.Title;  } }

        public static void pageOpen(string url) {

            _dr.Navigate().GoToUrl(url);
        }

        public static void Initialize() {

            pageOpen(_baseUrl);
        }

        public static void Close() {

            _dr.Close();
        }
    }
}
