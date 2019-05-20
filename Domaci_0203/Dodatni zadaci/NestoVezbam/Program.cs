using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestoVezbam
{
    class Program
    {
        static int[] Sortiranje (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        Swap(array[i], array[j]);
                    }
                }
            }
            return array;
        }

        static void Swap (int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int[] njanj = new int[] {1,5,7,8,43,6,7 };
            int[] resenje = Sortiranje(njanj);
            
            for (int i = 0; i < resenje.Length; i++)
            {
                Console.WriteLine(resenje[i] + " ");
            }
        }
    }
}
