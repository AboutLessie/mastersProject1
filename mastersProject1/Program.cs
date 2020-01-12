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
            //int counterOfChrom = 0;
            int iterations = 1000;
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
            int choose7 = random.Next(0, Tablica.Length);
            if (choose7 == choose1 || choose7 == choose2 || choose7 == choose3 || choose7 == choose4 || choose7 == choose5 || choose7 == choose6)
            {
                choose5 = random.Next(0, Tablica.Length);
            }
            int choose8 = random.Next(0, Tablica.Length);
            if (choose8 == choose1 || choose8 == choose2 || choose8 == choose3 || choose8 == choose4 || choose8 == choose5 || choose8 == choose6 || choose8 == choose7)
            {
                choose6 = random.Next(0, Tablica.Length);
            }

            Console.WriteLine(choose1);
            Console.WriteLine(choose2);
            Console.WriteLine(choose3);
            Console.WriteLine(choose4);
            Console.WriteLine(choose5);
            Console.WriteLine(choose6);
            Console.WriteLine(choose7);
            Console.WriteLine(choose8);

            for (int i = 0; i < iterations; i++)
            {

                string Chromosome1 = geneticAlgorithm.MakeChromosome(choose1);
                string Chromosome2 = geneticAlgorithm.MakeChromosome(choose2);
                string Chromosome3 = geneticAlgorithm.MakeChromosome(choose3);
                string Chromosome4 = geneticAlgorithm.MakeChromosome(choose4);
                string Chromosome5 = geneticAlgorithm.MakeChromosome(choose5);
                string Chromosome6 = geneticAlgorithm.MakeChromosome(choose6);
                string Chromosome7 = geneticAlgorithm.MakeChromosome(choose7);
                string Chromosome8 = geneticAlgorithm.MakeChromosome(choose8);

                double timeCh1 = readTime.GetTimeFromLog(choose1);
                double timeCh2 = readTime.GetTimeFromLog(choose2);
                double timeCh3 = readTime.GetTimeFromLog(choose3);
                double timeCh4 = readTime.GetTimeFromLog(choose4);
                double timeCh5 = readTime.GetTimeFromLog(choose5);
                double timeCh6 = readTime.GetTimeFromLog(choose6);
                double timeCh7 = readTime.GetTimeFromLog(choose7);
                double timeCh8 = readTime.GetTimeFromLog(choose8);


                List<double> times = new List<double>();
                times.Add(timeCh1);
                times.Add(timeCh2);
                times.Add(timeCh3);
                times.Add(timeCh4);
                times.Add(timeCh5);
                times.Add(timeCh6);
                times.Add(timeCh7);
                times.Add(timeCh8);
                times.Sort();

                string child1 = "";
                string child2 = "";
                string child3 = "";
                string child4 = "";

                if (times[0] == timeCh1)
                    {
                        child1 = Chromosome1;
                    }
                    if (times[0] == timeCh2)
                    {
                        child1 = Chromosome2;
                    }
                    if (times[0] == timeCh3)
                    {
                        child1 = Chromosome3;
                    }
                    if (times[0] == timeCh4)
                    {
                        child1 = Chromosome4;
                    }
                    if (times[0] == timeCh5)
                    {
                        child1 = Chromosome5;
                    }
                    if (times[0] == timeCh6)
                    {
                        child1 = Chromosome6;
                    }
                    if (times[0] == timeCh7)
                    {
                        child1 = Chromosome7;
                    }
                    if (times[0] == timeCh8)
                    {
                        child1 = Chromosome8;
                    }



                if (times[1] == timeCh1)
                {
                    child2 = Chromosome1;
                }
                if (times[1] == timeCh2)
                {
                    child2 = Chromosome2;
                }
                if (times[1] == timeCh3)
                {
                    child2 = Chromosome3;
                }
                if (times[1] == timeCh4)
                {
                    child2 = Chromosome4;
                }
                if (times[1] == timeCh5)
                {
                    child2 = Chromosome5;
                }
                if (times[1] == timeCh6)
                {
                    child2 = Chromosome6;
                }
                if (times[1] == timeCh7)
                {
                    child2 = Chromosome7;
                }
                if (times[1] == timeCh8)
                {
                    child2 = Chromosome8;
                }



                if (times[2] == timeCh1)
                {
                    child3 = Chromosome1;
                }
                if (times[2] == timeCh2)
                {
                    child3 = Chromosome2;
                }
                if (times[2] == timeCh3)
                {
                    child3 = Chromosome3;
                }
                if (times[2] == timeCh4)
                {
                    child3 = Chromosome4;
                }
                if (times[2] == timeCh5)
                {
                    child3 = Chromosome5;
                }
                if (times[2] == timeCh6)
                {
                    child3 = Chromosome6;
                }
                if (times[2] == timeCh7)
                {
                    child3 = Chromosome7;
                }
                if (times[2] == timeCh8)
                {
                    child3 = Chromosome8;
                }


                if (times[3] == timeCh1)
                {
                    child4 = Chromosome1;
                }
                if (times[3] == timeCh2)
                {
                    child4 = Chromosome2;
                }
                if (times[3] == timeCh3)
                {
                    child4 = Chromosome3;
                }
                if (times[3] == timeCh4)
                {
                    child4 = Chromosome4;
                }
                if (times[3] == timeCh5)
                {
                    child4 = Chromosome5;
                }
                if (times[3] == timeCh6)
                {
                    child4 = Chromosome6;
                }
                if (times[3] == timeCh7)
                {
                    child4 = Chromosome7;
                }
                if (times[3] == timeCh8)
                {
                    child4 = Chromosome8;
                }



                //Dictionary<int, string> dicFitnessFunction = new Dictionary<int, string>();
                //dicFitnessFunction.Clear();
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome1);
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome2);
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome3);
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome4);
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome5);
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome6);
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome7);
                //dicFitnessFunction.Add(counterOfChrom++, Chromosome8);

                //Dictionary<Dictionary<int, string>, double> dic = new Dictionary<Dictionary<int, string>, double>();
                //dic.Clear();
                //dic.Add(dicFitnessFunction, timeCh1);
                //dic.Add(dicFitnessFunction, timeCh2);
                //dic.Add(dicFitnessFunction, timeCh3);
                //dic.Add(dicFitnessFunction, timeCh4);
                //dic.Add(dicFitnessFunction, timeCh5);
                //dic.Add(dicFitnessFunction, timeCh6);
                //dic.Add(dicFitnessFunction, timeCh7);
                //dic.Add(dicFitnessFunction, timeCh8);

                //string child1 = geneticAlgorithm.MakeChild(dic, 0);
                //string child2 = geneticAlgorithm.MakeChild(dic, 1);
                //string child3 = geneticAlgorithm.MakeChild(dic, 2);
                //string child4 = geneticAlgorithm.MakeChild(dic, 3);


                int crossPoint = random.Next(0, 5);
                int childLen = child2.Count();
                string child1Removed = child1.Remove(0, crossPoint);
                string child2Removed = child2.Remove(crossPoint, childLen - crossPoint);
                StringBuilder newChildA = new StringBuilder(child1Removed + child2Removed);
                string newChild1 = newChildA.ToString();

                crossPoint = random.Next(0, 5);
                int childLen2 = child4.Count();
                string child3Removed = child3.Remove(0, crossPoint);
                string child4Removed = child4.Remove(crossPoint, childLen2 - crossPoint);
                StringBuilder newChildB = new StringBuilder(child3Removed + child4Removed);
                string newChild2 = newChildB.ToString();

                crossPoint = random.Next(0, 5);
                int childLen3 = child3.Count();
                string child5Removed = child1.Remove(0, crossPoint);
                string child6Removed = child3.Remove(crossPoint, childLen3 - crossPoint);
                StringBuilder newChildC = new StringBuilder(child5Removed + child6Removed);
                string newChild3 = newChildC.ToString();

                crossPoint = random.Next(0, 5);
                int childLen4 = child4.Count();
                string child7Removed = child1.Remove(0, crossPoint);
                string child8Removed = child4.Remove(crossPoint, childLen4 - crossPoint);
                StringBuilder newChildD = new StringBuilder(child7Removed + child8Removed);
                string newChild4 = newChildD.ToString();

                crossPoint = random.Next(0, 5);
                int childLen5 = child3.Count();
                string child9Removed = child2.Remove(0, crossPoint);
                string child10Removed = child3.Remove(crossPoint, childLen5 - crossPoint);
                StringBuilder newChildE = new StringBuilder(child9Removed + child10Removed);
                string newChild5 = newChildE.ToString();

                crossPoint = random.Next(0, 5);
                int childLen6 = child4.Count();
                string child11Removed = child2.Remove(0, crossPoint);
                string child12Removed = child4.Remove(crossPoint, childLen6 - crossPoint);
                StringBuilder newChildF = new StringBuilder(child11Removed + child12Removed);
                string newChild6 = newChildF.ToString();

                string newChild7 = child1;
                string newChild8 = child2;

                choose1 = Convert.ToInt32(newChild1, 2);
                choose2 = Convert.ToInt32(newChild2, 2);
                choose3 = Convert.ToInt32(newChild3, 2);
                choose4 = Convert.ToInt32(newChild4, 2);
                choose5 = Convert.ToInt32(newChild5, 2);
                choose6 = Convert.ToInt32(newChild6, 2);
                choose7 = Convert.ToInt32(newChild7, 2);
                choose8 = Convert.ToInt32(newChild8, 2);


                Console.WriteLine(newChild1);
                Console.WriteLine(newChild2);
                Console.WriteLine(newChild3);
                Console.WriteLine(newChild4);
                Console.WriteLine(newChild5);
                Console.WriteLine(newChild6);
                Console.WriteLine(newChild7);
                Console.WriteLine(newChild8);
                Console.WriteLine("\n");
            }



            Console.WriteLine("END");
            Console.ReadKey();
        }

    }
}
