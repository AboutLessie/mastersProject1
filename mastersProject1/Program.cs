using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest;

namespace mastersProject1
{
    public class Program
    {
        static void Main()
        {
            int iterations = 10;
            int countTest;
            Dictionary<int, double> bestResultGA = new Dictionary<int, double>();
            Dictionary<int, double> bestResultRandom = new Dictionary<int, double>();
            Console.WriteLine("Podaj liczbę testów do ułożenia");
            countTest = int.Parse(Console.ReadLine());

            GeneticMainProgram gmp = new GeneticMainProgram();
            bestResultGA = gmp.GeneticAlgorithm(iterations, countTest);

            RandomChoose rc = new RandomChoose();
            bestResultRandom = rc.RandomCalculations(iterations, countTest);
            Console.WriteLine("==============================================================================");
            Console.WriteLine("\nBest result for Genetic Algorithm is: {0} for choose {1}", bestResultGA.ElementAt(0).Value, bestResultGA.ElementAt(0).Key);
            Console.WriteLine("\nBest result for Random Choose is: {0} for choose {1}", bestResultRandom.ElementAt(0).Value, bestResultRandom.ElementAt(0).Key);
            Console.WriteLine("\nPress ENTER to exit program.");
            Console.ReadKey();
        }
    }
}
