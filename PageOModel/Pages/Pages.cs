using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOModel.Pages
{
    public static class Pages
    {

        private static T GetPage<T>() where T : new() {

            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static CookiePage CookieAccept {

            get { return GetPage<CookiePage>();  }
        }

        public static HomePage LatestNews {

            get { return GetPage<HomePage>();  }
        }

        public static LoginPage EnterPrivate {

            get { return GetPage<LoginPage>(); }        
        }


    }
}
