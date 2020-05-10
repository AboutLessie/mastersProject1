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
            Console.WriteLine("Podaj liczbę testów do ułożenia");
            countTest = int.Parse(Console.ReadLine());

            GeneticMainProgram.GeneticAlgorithm(iterations, countTest);

            RandomChoose.RandomCalculations(iterations, countTest);

        }
    }
}
