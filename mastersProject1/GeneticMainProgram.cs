using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastersProject1
{
    public class GeneticMainProgram
    {
        public void GeneticAlgorithm(int iterations, int countTest)
        {
            System.Random random = new System.Random();
            //int counterOfChrom = 0;
            readTime rt = new readTime();
            RunTest runT = new RunTest();

            //określenie ile jest możliwych kombinacji z danej liczby testów
            int a = countTest;
            int Opcje = geneticAlgorithm.Silnia1(a);
            string OpcjeLength = Convert.ToString(Opcje, 2);
            int length1 = OpcjeLength.Count();

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
            //losowanie chromosomów (nie mogą się początkowo powtarzać)
            int choose1 = random.Next(1, maxTablica);
            int choose2 = random.Next(1, maxTablica);
            if (choose1 == choose2)
            {
                choose2 = random.Next(1, maxTablica);
            }
            int choose3 = random.Next(1, maxTablica);
            if (choose3 == choose1 || choose3 == choose2)
            {
                choose3 = random.Next(1, maxTablica);
            }
            int choose4 = random.Next(1, maxTablica);
            if (choose4 == choose1 || choose4 == choose2 || choose4 == choose3)
            {
                choose4 = random.Next(1, maxTablica);
            }
            int choose5 = random.Next(1, maxTablica);
            if (choose5 == choose1 || choose5 == choose2 || choose5 == choose3 || choose5 == choose4)
            {
                choose5 = random.Next(1, maxTablica);
            }
            int choose6 = random.Next(1, maxTablica);
            if (choose6 == choose1 || choose6 == choose2 || choose6 == choose3 || choose6 == choose4 || choose6 == choose5)
            {
                choose6 = random.Next(1, maxTablica);
            }
            int choose7 = random.Next(1, maxTablica);
            if (choose7 == choose1 || choose7 == choose2 || choose7 == choose3 || choose7 == choose4 || choose7 == choose5 || choose7 == choose6)
            {
                choose5 = random.Next(1, maxTablica);
            }
            int choose8 = random.Next(1, maxTablica);
            if (choose8 == choose1 || choose8 == choose2 || choose8 == choose3 || choose8 == choose4 || choose8 == choose5 || choose8 == choose6 || choose8 == choose7)
            {
                choose6 = random.Next(1, maxTablica);
            }

            Console.WriteLine(choose1);
            Console.WriteLine(choose2);
            Console.WriteLine(choose3);
            Console.WriteLine(choose4);
            Console.WriteLine(choose5);
            Console.WriteLine(choose6);
            Console.WriteLine(choose7);
            Console.WriteLine(choose8);


            //WYKONANIE i RAZY ALGORYTMU GENETYCZNEGO - UZYSKIWANIE NOWYCH POKOLEŃ i RAZY
            for (int i = 0; i < iterations; i++)
            {

                //tworzenie chromosomow w postacji binarnej na podstawie ich numeru np. 1 = 00000001, 2 = 00000010 itp
                string Chromosome1 = geneticAlgorithm.MakeChromosome(choose1, length1);
                string Chromosome2 = geneticAlgorithm.MakeChromosome(choose2, length1);
                string Chromosome3 = geneticAlgorithm.MakeChromosome(choose3, length1);
                string Chromosome4 = geneticAlgorithm.MakeChromosome(choose4, length1);
                string Chromosome5 = geneticAlgorithm.MakeChromosome(choose5, length1);
                string Chromosome6 = geneticAlgorithm.MakeChromosome(choose6, length1);
                string Chromosome7 = geneticAlgorithm.MakeChromosome(choose7, length1);
                string Chromosome8 = geneticAlgorithm.MakeChromosome(choose8, length1);

                if(choose1 == 0)
                {
                    choose1 = random.Next(1, maxTablica);
                }
                if (choose2 == 0)
                {
                    choose2 = random.Next(1, maxTablica);
                }
                if (choose3 == 0)
                {
                    choose3 = random.Next(1, maxTablica);
                }
                if (choose4 == 0)
                {
                    choose4 = random.Next(1, maxTablica);
                }
                if (choose5 == 0)
                {
                    choose5 = random.Next(1, maxTablica);
                }
                if (choose6 == 0)
                {
                    choose6 = random.Next(1, maxTablica);
                }
                if (choose7 == 0)
                {
                    choose7 = random.Next(1, maxTablica);
                }
                if (choose8 == 0)
                {
                    choose8 = random.Next(1, maxTablica);
                }
                //odczytywanie wartości czasu pobranego po wykonaniu testów
                double timeCh1 = runT.TestRunner(choose1, possibilities[choose1]);
                double timeCh2 = runT.TestRunner(choose2, possibilities[choose2]);
                double timeCh3 = runT.TestRunner(choose3, possibilities[choose3]);
                double timeCh4 = runT.TestRunner(choose4, possibilities[choose4]);
                double timeCh5 = runT.TestRunner(choose5, possibilities[choose5]);
                double timeCh6 = runT.TestRunner(choose6, possibilities[choose6]);
                double timeCh7 = runT.TestRunner(choose7, possibilities[choose7]);
                double timeCh8 = runT.TestRunner(choose8, possibilities[choose8]);

                //wrzucenie wartości czasu do listy i posortowanie od najkrótszego (najlepszego)
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

                //zainicjowanie nowego pokolenia
                string child1 = "";
                string child2 = "";
                string child3 = "";
                string child4 = "";

                //wybranie najsilniejszych chromosomów aby powstały z nich 4 nowe osobniki
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


                //krzyżowanie najlepszych osobników
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

                //przepisanie dwóch najlepszych osobników bez krzyżowania
                string newChild7 = child1;
                string newChild8 = child2;

                //przekształcenie chromosomów z postaci binarnej na postać dziesiętną
                choose1 = Convert.ToInt32(newChild1, 2);
                choose2 = Convert.ToInt32(newChild2, 2);
                choose3 = Convert.ToInt32(newChild3, 2);
                choose4 = Convert.ToInt32(newChild4, 2);
                choose5 = Convert.ToInt32(newChild5, 2);
                choose6 = Convert.ToInt32(newChild6, 2);
                choose7 = Convert.ToInt32(newChild7, 2);
                choose8 = Convert.ToInt32(newChild8, 2);

                if (choose1 > maxTablica)
                {
                    choose1 = maxTablica;
                }
                if (choose2 > maxTablica)
                {
                    choose2 = maxTablica;
                }
                if (choose3 > maxTablica)
                {
                    choose3 = maxTablica;
                }
                if (choose4 > maxTablica)
                {
                    choose4 = maxTablica;
                }
                if (choose5 > maxTablica)
                {
                    choose5 = maxTablica;
                }
                if (choose6 > maxTablica)
                {
                    choose6 = maxTablica;
                }
                if (choose7 > maxTablica)
                {
                    choose7 = maxTablica;
                }
                if (choose8 > maxTablica)
                {
                    choose8 = maxTablica;
                }

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

            double time1 = rt.GetTimeFromLog(choose1);
            double time2 = rt.GetTimeFromLog(choose2);
            double time3 = rt.GetTimeFromLog(choose3);
            double time4 = rt.GetTimeFromLog(choose4);
            double time5 = rt.GetTimeFromLog(choose5);
            double time6 = rt.GetTimeFromLog(choose6);
            double time7 = rt.GetTimeFromLog(choose7);
            double time8 = rt.GetTimeFromLog(choose8);

            Console.WriteLine("Choose = {0} Time = {1}", choose1, time1);
            Console.WriteLine("Choose = {0} Time = {1}", choose2, time2);
            Console.WriteLine("Choose = {0} Time = {1}", choose3, time3);
            Console.WriteLine("Choose = {0} Time = {1}", choose4, time4);
            Console.WriteLine("Choose = {0} Time = {1}", choose5, time5);
            Console.WriteLine("Choose = {0} Time = {1}", choose6, time6);
            Console.WriteLine("Choose = {0} Time = {1}", choose7, time7);
            Console.WriteLine("Choose = {0} Time = {1}", choose8, time8);

            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
