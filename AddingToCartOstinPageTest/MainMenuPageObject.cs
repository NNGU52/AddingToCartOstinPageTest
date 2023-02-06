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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace AddingToCartOstinPageTest
{
    class MainMenuPageObject
    {
        IWebDriver driver;

        public readonly By saleButton = By.XPath("//a[@href='/catalog/sale']");

        public MainMenuPageObject(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void InstallUserAgentChrome()
        {

            //options.AddArgument("--disable-blink-features=AutomationControlled");
           
        }

        public void ClickElement(By locator)
        {
            var any = driver.FindElement(locator);
            any.Click();

            //bool b = WaitElement(saleButton);
            //while (b != true)
            //{
            //    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //    js.ExecuteScript("window.scrollBy(0,950);");
            //    b = WaitElement(saleButton);
            //}

            //var any = driver.FindElement(saleButton);
            //any.Click();
        }

        // явное ожидание 
        public bool WaitElement(By locator)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out that app in specific location: {locator}", ex);
            }
        }

    }
}
