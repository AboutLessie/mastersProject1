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

        public static string MakeChromosome(int choose)
        {
            string ch = Convert.ToString(choose, 2);
            string Chromosome = ch.PadLeft(5, '0');
            return Chromosome;
        }

        public static string MakeChild(Dictionary<Dictionary<int, string>, double> dic, int position)
        {
            var sortedFitnessFunction = dic.OrderBy(timeCh => timeCh.Value);
            var child1Obj = sortedFitnessFunction.ElementAt(position);
            var child1Value = child1Obj.Key;
            var childVal1 = child1Value.ElementAt(position);
            string child1 = childVal1.Value;
            return child1;
        }
    }
}
