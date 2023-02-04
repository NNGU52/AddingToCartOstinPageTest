using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace AddingToCartOstinPageTest
{
    class MainMenuPageObject
    {
        IWebDriver driver;

        public MainMenuPageObject(IWebDriver webDriver)
        {
            driver = webDriver;
        }

    }
}
