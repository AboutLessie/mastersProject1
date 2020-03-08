using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest
{
    public class TestExecutor
    {

     try
    {
                    IWebDriver driver = Configure.BrowserChoose();

        LogInOut logIn = new LogInOut();
        logIn.LogInTest(driver);

                    LogMaker log = new LogMaker();
        log.AddToLog("Udało się!");
                }
                catch (Exception e)
                {
                    LogMaker log = new LogMaker();
    log.AddToLog("Error " + e);
                }
                finally
                {
                    LogMaker log = new LogMaker();
log.CloseLog();
                }

    }
}
