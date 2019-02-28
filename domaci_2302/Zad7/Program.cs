using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{


    //Napisati C# konzolnu aplikaciju koja sabira prvih 20 parnih prirodnih brojeva koristeci for petlju. Ispisati rezultat


    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int counter = 0;            

            for (int i = 1; counter < 20; i++)
            {                
                if (i % 2 == 0)
                {
                    sum += i;
                    counter++;
                    //ubacio sam sledeci red da mi olaksa testiranje petlje
                    Console.WriteLine("Prolaz kroz petlju {0}, parni broj po redu {1}, ukupan zbir posle ovog prolaza {2}.", i, counter, sum);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Suma prvih 20 parnih prirodnih brojeva je {0}", sum);
            Console.ReadLine();
        }
    }
}
