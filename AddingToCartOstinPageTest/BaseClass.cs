using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace AddingToCartOstinPageTest
{
    public class BaseClass
    {
        protected static IWebDriver driver;

        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            //ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            //service.SuppressInitialDiagnosticInformation = true;
            //service.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:78.0) Gecko/20100101 Firefox/78.0");
            //options.AddArgument("--disable-blink-features=AutomationControlled");
            // скрыть надпись "Браузером Chrome управляет тестовое по"
            options.AddExcludedArgument("--enable-automation");
            //options.AddAdditionalCapability("useAutomationExtension", false);
            driver = new ChromeDriver(options);
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("Object.defineProperty(navigator, 'webdriver', {get: () => undefined})");

        }

        [SetUp]
        protected void DoBeforeEach()
        {
            driver.Navigate().GoToUrl(TestSettings.HostPrefix);
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
        }

        [TearDown]
        protected void DoAfterEach()
        {
            //driver.Quit();
        }

    }
}
