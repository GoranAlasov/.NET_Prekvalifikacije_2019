using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.14;
            double b = 12.8;
            double c = 4;

            double d = (a + b + c) / 3;

            Console.WriteLine("Srednja vrednost brojeva {0}, {1} i {2} zaokruzena na dve decimale je {3}.", a, b, c, Math.Round(d, 2));
            Console.ReadKey();
        }
    }
}
