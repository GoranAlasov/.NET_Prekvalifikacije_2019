using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 7.43;
            double c = 1.7;

            int brojElemenata = 3;
            int delilac = 7;

            double resenje = ((a + b + c) / brojElemenata) / delilac;

            Console.WriteLine("Srednja vrednost brojeva {0}, {1}, i {2} podeljena sa 7 je {3}.", a, b, c, resenje);
            Console.ReadKey();
        }
    }
}
