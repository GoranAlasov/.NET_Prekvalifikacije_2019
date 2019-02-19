using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokiDomaci_1902
{
    class Task1
    {
        public static void PlaceSwap(int variableA, int variableB)
        {
            Console.WriteLine($"Mesta promenljivih na pocetku su - mesto 1: {variableA} i mesto 2: {variableB}.");

            int temp = variableA;
            variableA = variableB;
            variableB = temp;

            Console.WriteLine($"Promenljive su sad zamenile mesta - mesto 1: {variableA} i mesto 2: {variableB}");
            Console.ReadKey();
        }
    }

    class Task2
    {
        public static void PlaceSwap2(int[] inputArray)
        {
            Console.Write("Ulazni niz je: ");

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == inputArray.Length - 1)
                {
                    Console.Write($"{inputArray[i]}.");
                }

                Console.Write($"{inputArray[i]}, ");
            }
            Console.WriteLine();


            int[] outputArray = new int[inputArray.Length];

            outputArray[inputArray.Length - 1] = inputArray[0];

            for (int i = 1; i < inputArray.Length; i++)
            {
                outputArray[i - 1] = inputArray[i];
            }


            Console.Write("Izlazni niz je: ");

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i == outputArray.Length - 1)
                {
                    Console.Write($"{outputArray[i]}.");
                    continue;
                }

                Console.Write($"{outputArray[i]}, ");
            }
            Console.ReadKey();
        }
    }

    class Task4
    {
        public static void MoreEvenOrOdd(int[] inputArray)
        {
            int evenCounter = 0;
            int oddCounter = 0;

            Console.Write("Ulazni niz je: ");

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == inputArray.Length - 1)
                {
                    Console.Write($"{inputArray[i]}.");
                    continue;
                }

                Console.Write($"{inputArray[i]}, ");
            }
            Console.WriteLine();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    evenCounter += 1;
                }
                else
                {
                    oddCounter += 1;
                }
            }

            if (oddCounter > evenCounter)
            {
                Console.WriteLine("U nizu ima vise neparnih brojeva.");
            }
            else if (evenCounter > oddCounter)
            {

                Console.WriteLine("U nizu ima vise parnih brojeva.");
            }
            else
            {
                Console.WriteLine("U nizu ima jednak broj parnih i neparnih brojeva.");
            }

            Console.ReadKey();
        }


        class Task5
        {
            public static void NaturalNumberSum(int numberCount)
            {
                int sum = (numberCount * (numberCount + 1)) / 2;

                Console.WriteLine($"Zbir prvih {numberCount} prirodnih brojeva je {sum}.");
                Console.ReadKey();
            }
        }

        class Task6
        {
            public static void MinimumValue(int[] inputArray)
            {
                int minimum = inputArray[0];

                Console.Write("Ulazni niz je: ");

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i == inputArray.Length - 1)
                    {
                        Console.WriteLine($"{inputArray[i]}.");
                    }

                    Console.Write($"{inputArray[i]}, ");

                    if (inputArray[i] < minimum)
                    {
                        minimum = inputArray[i];
                    }
                }

                Console.WriteLine("Najmanji clan niza je {0}.", minimum);
                Console.ReadKey();
            }
        }


        class Task7
        {
            public static void Sum3Numbers(double a, double b, double c)
            {
                double sum = a + b + c;
                Console.WriteLine("Suma brojeva {0}, {1} i {2} je {3}.", a, b, c, sum);
                Console.ReadKey();
            }
        }

        class Task8
        {
            public static void SumNNumbers(double[] inputArray)
            {
                Console.Write("Ulazni niz je: ");

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i == inputArray.Length - 1)
                    {
                        Console.Write($"{inputArray[i]}.");
                        continue;
                    }

                    Console.Write($"{inputArray[i]}, ");

                }
                Console.WriteLine();

                double sum = 0;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    sum += inputArray[i];
                }

                Console.WriteLine("Suma svih clanova ulaznog niza je {0}", sum);
                Console.ReadKey();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int[] myArray = new[] { 1, 2, 3, 4 };
                double[] myDoubleArray = new[] { 3.5, 56, 18.4, 4, 99.216, 3 };
                int numberCount = 17;
                double a = 67;
                double b = 4.57;
                double c = 10.5;                
            }
        }
    }
}


