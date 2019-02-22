using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_2002_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
                        

            if (a.GetType() == typeof(int) && b.GetType() == typeof(int))
            {
                Console.WriteLine("Promenljive su tipa integer.");
            }
            else
            {
                Console.WriteLine("Promenljive nisu tipa integer.");
            }

            Console.ReadKey();
        }        
    }
}
