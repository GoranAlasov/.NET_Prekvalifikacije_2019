using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 10;
            int c = 12;

            int d = a * b * c;

            Console.WriteLine("Proizvod promenljivih a ({0}), b ({1}) i c ({2}) je {3}.", a, b, c, d);
            Console.ReadKey();
        }
    }
}
