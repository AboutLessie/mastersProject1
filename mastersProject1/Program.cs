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
            if (choose1 == choose2)
            {
                choose2 = random.Next(0, Tablica.Length);
            }
            int choose3 = random.Next(0, Tablica.Length);
            if (choose3 == choose1 || choose3 == choose2)
            {
                choose3 = random.Next(0, Tablica.Length);
            }
            int choose4 = random.Next(0, Tablica.Length);
            if (choose4 == choose1 || choose4 == choose2 || choose4 == choose3)
            {
                choose4 = random.Next(0, Tablica.Length);
            }
            int choose5 = random.Next(0, Tablica.Length);
            if (choose5 == choose1 || choose5 == choose2 || choose5 == choose3 || choose5 == choose4)
            {
                choose5 = random.Next(0, Tablica.Length);
            }
            int choose6 = random.Next(0, Tablica.Length);
            if (choose6 == choose1 || choose6 == choose2 || choose6 == choose3 || choose6 == choose4 || choose6 == choose5)
            {
                choose6 = random.Next(0, Tablica.Length);
            }




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

            StringBuilder filePath1 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            filePath1.Append(choose1.ToString() + ".txt");
            string filePathA = filePath1.ToString();
            double timeCh1 = readTime.ReadFromLog(filePathA);

            StringBuilder filePath2 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            filePath2.Append(choose2.ToString() + ".txt");
            string filePathB = filePath2.ToString();
            double timeCh2 = readTime.ReadFromLog(filePathB);

            StringBuilder filePath3 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            filePath3.Append(choose3.ToString() + ".txt");
            string filePathC = filePath3.ToString();
            double timeCh3 = readTime.ReadFromLog(filePathC);

            StringBuilder filePath4 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            filePath4.Append(choose4.ToString() + ".txt");
            string filePathD = filePath4.ToString();
            double timeCh4 = readTime.ReadFromLog(filePathD);

            StringBuilder filePath5 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            filePath5.Append(choose5.ToString() + ".txt");
            string filePathE = filePath5.ToString();
            double timeCh5 = readTime.ReadFromLog(filePathE);

            StringBuilder filePath6 = new StringBuilder(@"C:\Users\Alicja\Desktop\Log\");
            filePath6.Append(choose6.ToString() + ".txt");
            string filePathF = filePath6.ToString();
            double timeCh6 = readTime.ReadFromLog(filePathF);

            
            Dictionary<double, string> dicFitnessFunction = new Dictionary<double, string>();
            dicFitnessFunction.Add(timeCh1, Chromosome01);
            dicFitnessFunction.Add(timeCh2, Chromosome02);
            dicFitnessFunction.Add(timeCh3, Chromosome03);
            dicFitnessFunction.Add(timeCh4, Chromosome04);
            dicFitnessFunction.Add(timeCh5, Chromosome05);
            dicFitnessFunction.Add(timeCh6, Chromosome06);

            SortedDictionary<double, string> sortedFitnessFunction = new SortedDictionary<double, string>(dicFitnessFunction);

            var child1Obj = sortedFitnessFunction.ElementAt(0);
            string child1 = child1Obj.Value;
            var child2Obj = sortedFitnessFunction.ElementAt(1);
            string child2 = child2Obj.Value;



        }

    }
}
