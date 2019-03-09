using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        /*    Napisati C# program koji od korisnika prima:
        a) niz nizova, gde su niz i podnizovi proizvoljne dužine koje unosi sam korisnik korisnik.
        b) unapred definisani niz nizova
            
            Npr.

            [
            [10, 14, 6, 1, 0, 24],
		    [4, 12, 2, 50],
		    [21, 8, 17],
		    [6, 9, 15, 11, 31]
	        ]
	
	    Nakon izbora opcije a ili b, ponuditi korisniku meni u kom bira da li želi ispis:
        Sume i Prosečne vrednosti svih elemenata
        Sumu i maksimalni element zadatog niza
        Zamenu nekog elementa niza nizova
        Ispis unetog niza nizova

        Za izlazak iz programa koristiti taster 0. (poželjno je koristiti potprograme za sve izbore koje korisnik bira) */

        static int CheckValue(int minValue, int maxValue)
        {
            int retVal;
            bool numberOk;

            do
            {
                numberOk = Int32.TryParse(Console.ReadLine(), out retVal) && retVal > minValue && retVal <= maxValue;
                if (!numberOk)
                {
                    Console.WriteLine("Pogresan unos probaj opet:");
                }

            } while (!numberOk);

            return retVal;
        }

        static int SumOfArrayElements(int[] array)
        {
            int retVal = array.Sum();
            return retVal;
        }

        static int SumOfJaggedArrayElements(int[][] jaggedArray)
        {
            int retVal = 0;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    retVal += jaggedArray[i][j];
                }
            }

            return retVal;
        }

        static double AvgOfArrayElements(int[] array)
        {
            double retVal = array.Average();
            return Math.Round(retVal, 2);
        }

        static double AverageOfJaggedArrayElements(int[][] jaggedArray)
        {
            double elementCounter = 0;
            double sum = 0;
            double retVal = 0;


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    sum += jaggedArray[i][j];
                    elementCounter++;
                }
            }

            retVal = sum / elementCounter;

            return Math.Round(retVal, 2);
        }

        static int MaximalArrayElement(int[] array)
        {
            int retVal = array.Max();
            return retVal;
        }

        static void PrintArray(int[] array)
        {
            Console.Write("\nElementi niza su: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.WriteLine($"{array[i]}.\n");
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }
            }
        }

        static void PrintJaggedArray(int[][] jaggedArray)
        {
            Console.WriteLine("\nElementi niza nizova su: ");
            Console.WriteLine("\n[");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(" {0}. niz:  [ {1}, ", (i + 1), jaggedArray[i][j]);
                    }
                    else if (j == jaggedArray[i].Length - 1)
                    {
                        Console.WriteLine("{0} ]", jaggedArray[i][j]);
                    }
                    else
                    {
                        Console.Write("{0}, ", jaggedArray[i][j]);
                    }
                }
            }

            Console.WriteLine("]");
        }

        //static int[] GetJaggedArrayElementCoodrinates(int[][] jaggedArray)
        //{
        //    int[] retVal = new int[] { (x - 1), (y - 1) };
        //    return retVal;
        //}

        static int[][] SwapJaggedArrayElements(int[][] jaggedArray, int[] coordinates1, int[] coordinates2)
        {
            int temp = jaggedArray[coordinates1[0]][coordinates1[1]];
            jaggedArray[coordinates1[0]][coordinates1[1]] = jaggedArray[coordinates2[0]][coordinates2[1]];
            jaggedArray[coordinates2[0]][coordinates2[1]] = temp;

            return jaggedArray;
        }

        static void Menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----------GLAVNI MENI----------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - unos niza nizova");
            Console.WriteLine("2 - predefinisan niz nizova");
            Console.WriteLine("0 - IZLAZ IZ PROGRAMA");
            int selection = CheckValue(0, 2);

            switch (selection)
            {
                case 1:
                //unesi array
                case 2:
                    Menu2(jaggedArray)
                case 0:
                default:
                    break;
            }
        }

        

        static void Main(string[] args)
        {

            int[][] glupiNiz = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 10, 20, 30 }, new int[] { 100, 200 } };

            PrintJaggedArray(glupiNiz);

            glupiNiz = SwapJaggedArrayElements(glupiNiz, new int[2] {0, 1 }, new int[] { 2, 0});

            PrintJaggedArray(glupiNiz);

            //int sum = SumOfJaggedArrayElements(glupiNiz);
            //double avg = AverageOfJaggedArrayElements(glupiNiz);

            Console.WriteLine(a);
            Menu();
            Console.Read();
        }

    }
}
