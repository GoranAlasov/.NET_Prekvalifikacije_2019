using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int privremena = 0;

            b += 3;

            privremena = a;
            a = b;
            b = privremena;

            Console.WriteLine("Vrednost promeljive a je " + a + ".");
            Console.WriteLine("Vrednost promenljive b je {0}.",b);
            Console.ReadKey();
        }
    }
}
