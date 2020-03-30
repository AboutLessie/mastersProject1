using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotest.Pages
{
    public interface IMainPage
    {
        IWebElement FindLogInTextBox(IWebDriver driver);
        IWebElement LogInBtn(IWebDriver driver);
        IWebElement Minimalize(IWebDriver driver);
        IWebElement More(IWebDriver driver);
        IWebElement PassBox(IWebDriver driver);
        IWebElement SearchBox(IWebDriver driver);
    }
}
