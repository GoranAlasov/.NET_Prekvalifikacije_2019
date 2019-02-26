using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            long c = a + b; //rezultat sabiranja ce potencijalno izaci iz opsega int-a

            Console.WriteLine($"Zbir promenljive a ({a}) i promenljive b ({b}) je {c}.");
            Console.ReadKey();
        }
    }
}
