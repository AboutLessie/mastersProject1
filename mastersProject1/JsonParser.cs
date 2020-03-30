using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace mastersProject1
{
    public class JsonParser
    {

        public static void CreateJsonConfigFile(string ConfigData, int ktoreUlozenie)
        {
            //tworzenie pliku .json z informacją o kolejności wykonywania testów
            string kombinacjaTestow = ConfigData;
            char[] c = kombinacjaTestow.ToCharArray();
            int ileTestowWykonac = c.Length;
            string nazwaTestu;
            List<string> listaTestow = new List<string>();
            for (int i = 1; i <= ileTestowWykonac ; i++)
            {
                StringBuilder sb = new StringBuilder("Test");
                sb.Append(i);
                nazwaTestu = sb.ToString();
                listaTestow.Add(nazwaTestu);
            }

            StringBuilder filePath1 = new StringBuilder(@"C:\Users\Alicja\Desktop\Config\");
            filePath1.Append(ktoreUlozenie.ToString() + ".txt");
            string filePath = filePath1.ToString();
            StreamWriter sw = new StreamWriter(filePath);
            

            Dictionary<string, char> listaKolejnosciWykonaniaTestow = new Dictionary<string, char>();
            for(int j = 0; j < ileTestowWykonac; j++)
            {
                listaKolejnosciWykonaniaTestow.Add(listaTestow[j], c[j]);
                sw.WriteLine("{0} = {1}", listaTestow[j], c[j]);
            }
            sw.Close();          


        }
    }
}
