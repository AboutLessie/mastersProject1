using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastersProject1
{
    public class RandomChoose
    {
        public void RandomCalculations(int iterations, int countTest)
        {
            Console.WriteLine("Random Calculations");
            readTime rt = new readTime();
            Random random = new System.Random();
            //int counterOfChrom = 0;
            
            //określenie ile jest możliwych kombinacji z danej liczby testów
            int a = countTest;
            int Opcje = geneticAlgorithm.Silnia1(a);
            
            //utworzenie tablicy do określenia długości binarnej wersji chromosomu
            int[] Tablica = new int[Opcje];
            for (int i = 0; i < Opcje - 1; i++)
                Tablica[i] = Opcje - 1;

            //stworzenie tablicy z wszystkimi możliwymi kombinacjami danej liczby testów
            PermuteOptions po = new PermuteOptions();
            po.GetPer(a);
            int count = po.possibilities.Count;
            int[][] possibilities = po.possibilities.ToArray();
            int maxTablica = Tablica.Length - 1;

            int chooseA = random.Next(0, maxTablica);
            //double timeA = RunTest.TestRunner(chooseA, possibilities[chooseA - 1]);
            double timeA = rt.GetTimeFromLog(chooseA);
            Console.WriteLine("{0} time={1}", chooseA, timeA);
            
            for (int i = 0; i < iterations; i++)
            {
                double resultTime;
                int resultChoose;
                int chooseB = random.Next(0, maxTablica);
                //double timeB = RunTest.TestRunner(chooseB, possibilities[chooseB - 1]);
                double timeB = rt.GetTimeFromLog(chooseB);
                Console.WriteLine("{0} time={1}", chooseB, timeB);
                if (timeA > timeB)
                {
                    resultTime = timeB;
                    resultChoose = chooseB;
                    chooseA = chooseB;
                    timeA = timeB;
                }
                else
                {
                    resultTime = timeA;
                    resultChoose = chooseA;
                }
                Console.WriteLine("Best result is: {0} for choose {1}", resultTime, resultChoose);
            }

            Console.WriteLine("Number of iterations in general: {0}", iterations);
            Console.ReadLine();
            
        }
    }
}
