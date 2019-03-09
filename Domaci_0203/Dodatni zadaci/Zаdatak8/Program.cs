using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zаdatak8
{
    class Program
    {
        static int[][] NumerCountToArray(int[] numberArray)
        {
            int jaggedArraysCount = numberArray.Length;

            int[][] resultingJaggedArray = new int[jaggedArraysCount][];            

            for (int i = 0; i < numberArray.Length; i++)
            {
                resultingJaggedArray[i] = new int[numberArray[i]];
            }

            return resultingJaggedArray;
        }

        static void PrintJaggedArray(int[][] jaggedArray)
        {
            Console.WriteLine("[");
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                Console.Write("  [ ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i].Length == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("{0} ", jaggedArray[i][j]);
                    }                    
                }
                Console.WriteLine("]");
            }
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 4, 7, 2, 0, 5 };
            PrintJaggedArray(NumerCountToArray(array));            
        }
    }
}
