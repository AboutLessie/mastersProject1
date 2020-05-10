using OpenQA.Selenium;
using System;
using System.IO;
using System.Text;
using Autotest.Configuration;
using Autotest.Tests;
using Autotest.Logger;
using System.Diagnostics;
using System.Collections.Generic;
using System.Reflection;

namespace mastersProject1
{
    public class RunTest
    {
     
        public static Boolean LogExist(int choose)
        {
           // StringBuilder filePath1 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            StringBuilder filePath1 = new StringBuilder(@"C:\Users\Alicja\Desktop\OSOBISTE\UAM\Magisterka\Log\");
            filePath1.Append(choose.ToString() + ".txt");
            string filePathA = filePath1.ToString();
            bool fileExist = File.Exists(filePathA);
            return fileExist;
        }

        public double TestRunner(int choose, int[] chooseList)
        {
            readTime rt = new readTime();
            if(!LogExist(choose))
            {
                RunAllTest(chooseList);
            }
            double timeCh = rt.GetTimeFromLog(choose);
            return timeCh;
        }

        public void RunAllTest(int[] chooseList)
        {
            List<string> orderTests = new List<string>();
            for (int i=0;i<chooseList.Length;i++)
            {
                orderTests.Add("Test" + chooseList[i].ToString());
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            try
            {
                IWebDriver driver;
                driver = Configure.BrowserChoose("Chrome");

                LogInOut logIn = new LogInOut();

                for(int j = 0; j < orderTests.Count; j++)
                {
                    MethodInfo mi = this.GetType().GetMethod(orderTests[j]);
                    LogInOut logInClass = new LogInOut();
                    mi.Invoke(this, null);
                }
                
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
