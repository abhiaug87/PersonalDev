using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
namespace PersonalDev.Utilities
{
    public class DriverFactory
    {
        public static IWebDriver InitiateWebDriver(string browser)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(
            "--window-size=1920,1080",
            "--allow-insecure-localhost",
            "--headless",
            "--disable-gpu",
            "--no-sandbox"
         );
            IWebDriver? driver = null;
            if (browser.Equals(CommonConstants.DriverSettings.HeadlessBrowser))
            {
                driver = new ChromeDriver(CommonConstants.DriverSettings.BinaryLocationChrome, chromeOptions);
            }
            else if (browser.Equals(CommonConstants.DriverSettings.ChromeBrowser))
            {
                driver = new ChromeDriver(CommonConstants.DriverSettings.BinaryLocationChrome);
            }
            else if (browser.Equals(CommonConstants.DriverSettings.EdgeBrowser))
            {
                driver = new EdgeDriver(CommonConstants.DriverSettings.BinaryLocationEdge);
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(CommonConstants.DriverSettings.DefaultWaitTime);
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
