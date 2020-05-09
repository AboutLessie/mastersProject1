using OpenQA.Selenium;
using System;
using System.IO;
using System.Text;
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

        public static double TestRunner(int choose, int[] chooseList)
        {
            if(!LogExist(choose))
            {
                RunAllTest(chooseList);
            }
            double timeCh = readTime.GetTimeFromLog(choose);
            return timeCh;
        }

        public static void RunAllTest(int[] chooseList)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            try
            {
                IWebDriver driver;
                driver = Configure.BrowserChoose("Chrome");

                LogInOut logIn = new LogInOut();

                logIn.Test1(driver);
                logIn.Test2(driver);
                logIn.Test3(driver);
                logIn.Test4(driver);

                LogMaker log = new LogMaker();
            }
            catch (Exception e)
            {
                LogMaker log = new LogMaker();
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
