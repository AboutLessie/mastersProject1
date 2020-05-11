using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;

namespace Autotest.Configuration
{
     public class Configure : IConfigure
     {
        public static IWebDriver BrowserChoose(string driverType)
        {
            IWebDriver driver = null;
            switch (driverType)
            {
                case "Chrome":
                    {
                        driver = new ChromeDriver(@"C:\git\ContactCenter\AutomationTest\Drivers");
                        driver.Manage().Window.Maximize();
                        return driver;
                    }
                default:
                    {
                        driver = new InternetExplorerDriver(@"C:\git\ContactCenter\AutomationTest\Drivers");
                        driver.Manage().Window.Maximize();
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
                        return driver;
                    }
            }
        }

    }
}
