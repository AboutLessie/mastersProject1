using Autotest.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotest.Tests
{
    public class LogInOut
    {
        private readonly IMainPage _mainPage;

        public LogInOut(IMainPage mainPage)
        {
            _mainPage = mainPage;
        }

        public void Test1(IWebDriver driver)
        {
            string url = "https://jira.wmi.amu.edu.pl/secure/Dashboard.jspa";
            driver.Navigate().GoToUrl(url);

            _mainPage.FindLogInTextBox(driver).Click();
            _mainPage.PassBox(driver).Click();
            _mainPage.LogInBtn(driver).Click();
        }

        public void Test2(IWebDriver driver)
        {
            string url = "https://jira.wmi.amu.edu.pl/secure/Dashboard.jspa";
            driver.Navigate().GoToUrl(url);

            _mainPage.LogInBtn(driver).Click();
        }

        public void Test3(IWebDriver driver)
        {
            string url = "https://jira.wmi.amu.edu.pl/secure/Dashboard.jspa";
            driver.Navigate().GoToUrl(url);

            _mainPage.SearchBox(driver).Click();
            _mainPage.SearchBox(driver).SendKeys("help");
            _mainPage.SearchBox(driver).SendKeys(Keys.Enter);


        }
        public void Test4(IWebDriver driver)
        {
            string url = "https://jira.wmi.amu.edu.pl/secure/Dashboard.jspa";
            driver.Navigate().GoToUrl(url);

            _mainPage.More(driver).Click();
            _mainPage.Minimalize(driver).Click();
        }
    }
}
