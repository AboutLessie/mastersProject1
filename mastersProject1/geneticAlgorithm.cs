using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastersProject1
{
    public class geneticAlgorithm
    {
        public static int Silnia1(int x)
        {
            int wynikSilnia = 1;
            if (x < 1)
                return 1;
            else
                for (int i = 1; i <= x; i++)
                    wynikSilnia = wynikSilnia * i;
            return wynikSilnia;
        }

    }
}
