﻿using OpenQA.Selenium;
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
    }
}
