using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        public static int[] Union(int[] array1, int[] array2)
        {
            int[] joinedArray = new int[array1.Length + array2.Length];

            for (int i = 0; i < joinedArray.Length; i++)
            {
                if (i < array1.Length)
                {
                    joinedArray[i] = array1[i];
                }
                else
                {
                    joinedArray[i] = array2[i - array1.Length];
                }
            }

            int[] retVal = joinedArray.Distinct().ToArray();
            return retVal;
            
        }

        public static int[] Intersection(int[] array1, int[] array2)
        {
            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    int countThis = 0;
                    if (array1[i] == array2[j])
                    {
                        countThis++;

                        if (countThis <= 1)
                        {
                            count++;
                        }
                    }
                }
            }

            int[] intersection = new int[count];

            count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        intersection[count] = array1[i];
                        count++;
                        break;
                    }
                }
            }
            return intersection;
        }

        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] { 4, 5, 6, 7, 8, 9 };


            Console.WriteLine("Union");
            int[] joinedArray = Union(array1, array2);

            for (int i = 0; i < joinedArray.Length; i++)
            {
                Console.Write(joinedArray[i]);
            }

            Console.WriteLine("\nIntersection");
            int[] intersectedArray = Intersection(array1, array2);

            for (int i = 0; i < intersectedArray.Length; i++)
            {
                Console.Write(intersectedArray[i]);
            }
            Console.Read();
        }
    }
}
