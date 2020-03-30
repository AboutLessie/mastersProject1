using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotest.Pages
{
    public class MainPage : IMainPage
    {
        private const string logInTextBoxXPath = "//input[@id='login-form-username']";
        private const string passBox = "//input[@id='login-form-password']";
        private const string logInbtn = "//input[@id='login']";
        private const string SearchBoxX = "//input[@id='quickSearchInput']";
        private const string moreXpath = "//div[@id='gadget-10000-chrome']//a[@id='']";
        private const string minimalizeBtn = "//ul[@class='aui-dropdown standard aui-dropdown-right hidden']//a[@class='item-link minimization'][contains(text(),'Minimize')]";



        public IWebElement FindLogInTextBox(IWebDriver driver) => driver.FindElement(By.XPath(logInTextBoxXPath));
        public IWebElement PassBox(IWebDriver driver) => driver.FindElement(By.XPath(passBox));
        public IWebElement LogInBtn(IWebDriver driver) => driver.FindElement(By.XPath(logInbtn));
        public IWebElement SearchBox(IWebDriver driver) => driver.FindElement(By.XPath(SearchBoxX));
        public IWebElement More(IWebDriver driver) => driver.FindElement(By.XPath(moreXpath));
        public IWebElement Minimalize(IWebDriver driver) => driver.FindElement(By.XPath(minimalizeBtn));
    }
}
