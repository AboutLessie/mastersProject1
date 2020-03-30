using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastersProject1
{
    public class PermuteOptions
    {
        /** 
        * permutation function 
        * @param str string to  
           calculate permutation for 
        * @param l starting index 
        * @param r end index 
        */
        public static string[] Permute(String str, int l, int r, int Opcje)
        {
            string[] TablicaOpcjiUlozenia = new string[Opcje];
            if (l == r)
            {
                int mozliwosc = new int();
                if (TablicaOpcjiUlozenia[0] == null)
                {
                    mozliwosc = 0;
                }
                Console.WriteLine(str);
                TablicaOpcjiUlozenia[mozliwosc] = str;
                mozliwosc++;
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    Permute(str, l + 1, r, Opcje);
                    str = swap(str, l, i);
                }
            }
            return TablicaOpcjiUlozenia;
        }

        /** 
        * Swap Characters at position 
        * @param a string value 
        * @param i position 1 
        * @param j position 2 
        * @return swapped string 
        */
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        // Driver Code 
        public static string[] ExecPermute(int choice, int Opcje)
        {
            StringBuilder sb = new StringBuilder();
            String optionsString = "";

            for (int i = 1; i <= choice; i++)
            {
                string iString = i.ToString();
                sb.Append(iString);
            }
            optionsString = sb.ToString();
            String str = optionsString;
            int n = str.Length;
            string[] TablicaOpcjiUlozenia = new string[Opcje];
            TablicaOpcjiUlozenia = Permute(str, 0, n - 1, Opcje);
            return TablicaOpcjiUlozenia;
        }
    }
}

