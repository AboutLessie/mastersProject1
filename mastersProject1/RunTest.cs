using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest;
using Autotest.Configuration;
using Autotest.Tests;
using Autotest.Logger;
using System.Diagnostics;

namespace mastersProject1
{
    public class RunTest
    {

        private readonly IConfigure _configure;
        public RunTest(int chosenTest, IConfigure configure)
        {
            int choose = chosenTest;
            _configure = configure;
        }
     
        
        public static Boolean LogExist(int choose)
        {
            StringBuilder filePath1 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            filePath1.Append(choose.ToString() + ".txt");
            string filePathA = filePath1.ToString();
            bool fileExist = File.Exists(filePathA);
            return fileExist;
        }

        public static double TestRunner(int choose)
        {
            if(!LogExist(choose))
            {
                RunAllTest();
            }
            double timeCh = readTime.GetTimeFromLog(choose);
            return timeCh;
        }

        public static void RunAllTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            try
            {
                IWebDriver driver;
                driver = Configure.BrowserChoose("Chrome");

                LogInOut logIn = new LogInOut();
                logIn.Test1(driver);

                LogMaker log = new LogMaker();
                //og.AddToLog("Udało się!");
            }
            catch (Exception e)
            {
                LogMaker log = new LogMaker();
                //log.AddToLog("Error " + e);
            }
            finally
            {
                LogMaker log = new LogMaker();
                sw.Stop();
                log.AddToLog(sw.Elapsed.ToString());
                log.CloseLog();
            }
        }



    }
}
