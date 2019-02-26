using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 14;

            double c = a / b;

            Console.WriteLine("Vrednost promenljive c zaokruzena na 5 decimala je {0}.", Math.Round(c, 5));
            Console.ReadKey();
        }
    }
}
