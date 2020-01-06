using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastersProject1
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();

            int countTest;
            Console.WriteLine("Podaj liczbę testów do ułożenia");
            countTest = int.Parse(Console.ReadLine());

            int a = countTest;
            int Opcje = geneticAlgorithm.Silnia1(a);

            int[] Tablica = new int[Opcje];
            for (int i = 1; i <= Opcje - 1; i++)
                Tablica[i] = Opcje - 1;

            int choose1 = random.Next(0, Tablica.Length);
            int choose2 = random.Next(0, Tablica.Length);
            int choose3 = random.Next(0, Tablica.Length);
            int choose4 = random.Next(0, Tablica.Length);
            int choose5 = random.Next(0, Tablica.Length);
            int choose6 = random.Next(0, Tablica.Length);

            string Chromosome1 = Convert.ToString(choose1, 2);
            string Chromosome01 = Chromosome1.PadLeft(5, '0');

            string Chromosome2 = Convert.ToString(choose2, 2);
            string Chromosome02 = Chromosome2.PadLeft(5, '0');

            string Chromosome3 = Convert.ToString(choose3, 2);
            string Chromosome03 = Chromosome3.PadLeft(5, '0');

            string Chromosome4 = Convert.ToString(choose4, 2);
            string Chromosome04 = Chromosome4.PadLeft(5, '0');

            string Chromosome5 = Convert.ToString(choose5, 2);
            string Chromosome05 = Chromosome5.PadLeft(5, '0');

            string Chromosome6 = Convert.ToString(choose6, 2);
            string Chromosome06 = Chromosome6.PadLeft(5, '0');

            StringBuilder filePath = new StringBuilder(@"C:\Users\Alicja\Desktop\Logs\");
            filePath.Append(choose1.ToString()+".txt");
            string filePath1 = filePath.ToString();
            readTime.ReadFromLog(filePath1);
            //double fitnessTime = readTime.
        }

    }
}
