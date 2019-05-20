using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Program
    {
        static int[] ChangeArray(int[] array, int moveBy)
        {
            int[] array2 = new int[array.Length];

            if (moveBy > array.Length)
            {
                Console.WriteLine("Broj ne moze biti veci od broja clanova niza.");
                return array;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i > (moveBy - 1))
                    {
                        array2[i - moveBy] = array[i];
                    }
                    else
                    {
                        array2[array2.Length - (moveBy - i)] = array[i];
                    }
                }
            }
            return array2;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = ChangeArray(array, 1);

            Console.WriteLine("Ulazni niz");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Izlazni niz");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.Read();
        }
    }
}
