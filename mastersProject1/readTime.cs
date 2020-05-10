using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace mastersProject1
{
    public class readTime
    {
        public static double ReadFromLog(string filePath)
        {
            var dic = File.ReadAllLines(filePath)
                           .Select(line => line.Split('='))
                           .ToDictionary(s => s[0].Trim(), s => s[1].Trim());
            string timeSum = dic["TimeSum"];
            double time = Convert.ToDouble(timeSum);
            return time;
        }

        public double GetTimeFromLog(int choose)
        {
            //StringBuilder filePath1 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            StringBuilder filePath1 = new StringBuilder(@"C:\Users\Alicja\Desktop\OSOBISTE\UAM\Magisterka\Log\");
            filePath1.Append(choose.ToString() + ".txt");
            string filePathA = filePath1.ToString();
            double timeCh = ReadFromLog(filePathA);
            return timeCh;
        }

    }
}
