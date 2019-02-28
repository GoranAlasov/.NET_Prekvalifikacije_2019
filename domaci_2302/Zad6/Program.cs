using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{


    //Napisati C# konzolnu aplikaciju koja ispisuje prvih 10 neparnih prirodnih brojeva koristeći while petlju.


    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number = 1;

            Console.WriteLine("Prvih 10 neparnih prirodnih brojeva su: ");

            while (counter < 10)
            {
                if (number % 2 != 0)
                {
                    Console.Write("{0}   ", number);
                    counter++;
                }                
                number++;
            }
            Console.ReadLine();
        }
    }
}
