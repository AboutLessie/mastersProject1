using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastersProject1
{
    public class PermuteOptions
    { 
        private static void Swap(ref int a, ref int b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        public static int[] GetPer(int liczba)
        {
            List<int> inters = new List<int>();
            for(int i = 1; i <= liczba; i++)
            {
                inters.Add(i);
            }
            int[] tablica = inters.ToArray();

            int x = tablica.Length - 1;
            return GetPer(tablica, 0, x);
        }
        public static Stack<int[]> possibilities = new Stack<int[]>();
        private static int[] GetPer(int[] list, int k, int m)
        {
            if (k == m)
            {
                possibilities.Push(list);
                return list;
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
            return null;
        }
    }
}

