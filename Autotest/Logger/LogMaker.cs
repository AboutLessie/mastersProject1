﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotest.Logger
{
    public class LogMaker : ILogMaker
    {
        public LogMaker(int choose)
        {
            LogName = choose.ToString() + ".txt";
        }

        public string LogName { get; set; }

        public void AddToLog(string text)
        {
            string logFile = @"C:\Users\Alicja\Desktop\OSOBISTE\UAM\Magisterka\Log\" + LogName;
            using (FileStream fs = new FileStream(logFile, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(text);
                }
            }
        }

        public void CloseLog()
        {
            string logFile = @"C:\Users\Alicja\Desktop\LogsTutorial\"+ LogName;
            using (FileStream fs = new FileStream(logFile, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Done");
                }
            }
        }

        public string GetDate()
        {
            var date = DateTime.Now;
            var n = long.Parse(date.ToString("yyyyMMddHHmm"));
            return n.ToString();
        }
    }
}
