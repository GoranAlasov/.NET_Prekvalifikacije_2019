using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokiDomaci_1902
{
    class Zadatak1
    {
        public static void PromenaMesta(int promenljivaA, int promenljivaB)
        {
            Console.WriteLine($"Mesta promenljivih na pocetku su - mesto 1: {promenljivaA} i mesto 2: {promenljivaB}.");

            int pomocna = promenljivaA;
            promenljivaA = promenljivaB;
            promenljivaB = pomocna;

            Console.WriteLine($"Promenljive su sad zamenile mesta - mesto 1: {promenljivaA} i mesto 2: {promenljivaB}");
            Console.ReadKey();
        }
    }

    class Zadatak2
    {
        public static void PromenaMesta2(int[] ulazniNiz)
        {
            Console.Write("Ulazni niz je: ");

            for (int i = 0; i < ulazniNiz.Length; i++)
            {
                if (i == ulazniNiz.Length - 1)
                {
                    Console.Write($"{ulazniNiz[i]}.");
                    continue;
                }

                Console.Write($"{ulazniNiz[i]}, ");
            }
            Console.WriteLine();


            int[] izlazniNiz = new int[ulazniNiz.Length];
            int privremena = ulazniNiz[0];

            izlazniNiz[ulazniNiz.Length - 1] = ulazniNiz[0];

            for (int i = 1; i < ulazniNiz.Length; i++)
            {
                izlazniNiz[i - 1] = ulazniNiz[i];
            }


            Console.Write("Izlazni niz je: ");

            for (int i = 0; i < ulazniNiz.Length; i++)
            {
                if (i == ulazniNiz.Length - 1)
                {
                    Console.Write($"{ulazniNiz[i]}.");
                    continue;
                }

                Console.Write($"{izlazniNiz[i]}, ");
            }
            Console.ReadKey();
        }
    }

    class Zadatak4
    {
        public static void ViseParnihIliViseNeparnih(int[] ulazniNiz)
        {
            int brojacParnih = 0;
            int brojacNeparnih = 0;

            Console.Write("Ulazni niz je: ");

            for (int i = 0; i < ulazniNiz.Length; i++)
            {
                if (i == ulazniNiz.Length - 1)
                {
                    Console.Write($"{ulazniNiz[i]}.");
                    continue;
                }

                Console.Write($"{ulazniNiz[i]}, ");
            }
            Console.WriteLine();

            for (int i = 0; i < ulazniNiz.Length; i++)
            {
                if (ulazniNiz[i] % 2 == 0)
                {
                    brojacParnih += 1;
                }
                else
                {
                    brojacNeparnih += 1;
                }
            }

            if (brojacNeparnih > brojacParnih)
            {
                Console.WriteLine("U nizu ima vise neparnih brojeva.");
            }
            else
            {
                if (brojacParnih > brojacNeparnih)
                {
                    Console.WriteLine("U nizu ima vise parnih brojeva.");
                }
                else
                {
                    Console.WriteLine("U nizu ima jednak broj parnih i neparnih brojeva.");
                }
            }

            Console.ReadKey();
        }
    }

    class Zadatak5
    {
        public static void SumaPrirodnihBrojeva(int kolikoBrojeva)
        {
            int zbir = (kolikoBrojeva * (kolikoBrojeva + 1)) / 2;

            Console.WriteLine($"Zbir prvih {kolikoBrojeva} prirodnih brojeva je {zbir}.");
            Console.ReadKey();
        }
    }

    class Zadatak6
    {
        public static void PronalazenjeMinimuma(int[] ulazniNiz)
        {
            int minimum = ulazniNiz[0];

            Console.Write("Ulazni niz je: ");

            for (int i = 0; i < ulazniNiz.Length; i++)
            {
                if (i == ulazniNiz.Length - 1)
                {
                    Console.WriteLine($"{ulazniNiz[i]}.");
                    continue;
                }

                Console.Write($"{ulazniNiz[i]}, ");                

                if (ulazniNiz[i] < minimum)
                {
                    minimum = ulazniNiz[i];
                    continue;
                }
            }

            Console.WriteLine("Najmanji clan niza je {0}.", minimum);
            Console.ReadKey();
        }
    }


    class Zadatak7
    {
        public static void SumaTriBroja(double a, double b, double c)
        {
            double suma = a + b + c;
            Console.WriteLine("Suma brojeva {0}, {1} i {2} je {3}.", a, b, c, suma);
            Console.ReadKey();
        }
    }

    class Zadatak8
    {
        public static void SumaNBrojeva(double[] ulazniNiz)
        {
            Console.Write("Ulazni niz je: ");

            for (int i = 0; i < ulazniNiz.Length; i++)
            {
                if (i == ulazniNiz.Length - 1)
                {
                    Console.Write($"{ulazniNiz[i]}.");
                    continue;
                }

                Console.Write($"{ulazniNiz[i]}, ");

            }
            Console.WriteLine();

            double suma = 0;

            for (int i = 0; i < ulazniNiz.Length; i++)
            {
                suma += ulazniNiz[i];
            }

            Console.WriteLine("Suma svih clanova ulaznog niza je {0}", suma);
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] mojNiz = new[] { 213, 56, 8, 15, 1, 69, 75, 18, 55 };
            double[] mojDobuleNiz = new[] { 3.5, 56, 18.4, 4, 99.216, 3 };
            int kolikoPrirodnihBrojeva = 17;
            double a = 67;
            double b = 4.57;
            double c = 10.5;            
        }
    }
}


