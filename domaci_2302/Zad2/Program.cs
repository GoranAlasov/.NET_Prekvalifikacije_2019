using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{


    //Napraviti promenljivu a sa vrednošću 5 i promenljivu b sa vrednošću zbira broja 9 i stringa "4". 
    //Ukoliko su obe promenljive tipa integer, ispisati poruku "Promenljive su tipa integer" i ispisati njihov zbir, 
    //u suprotnom ispisati "Promenljive nisu tipa integer". Koristiti metodu GetType i if/else.


    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 9 + "4";

            if (a.GetType() == typeof(int) && b.GetType() == typeof(int))
            {
                Console.WriteLine("Promenljive su tipa integer. Njihov zbir je {0}.", a+b);
            }
            else
            {
                string aText = ConvertTypeToText(a.GetType());
                string bText = ConvertTypeToText(b.GetType());
                
                Console.WriteLine("Promenljive nisu tipa integer. Tip promenljive a je {0}, a tip promenljive b je {1}.", aText, bText);
            }
            
            Console.ReadLine();
        }

        static string ConvertTypeToText (Type type) //metoda koja prima tip promenljive i vraca naziv tog tipa kao string pogodan za ispis
        {
            string text = type.ToString();
            string output = "";
            
            //uradio sam samo za situacije kada je tip string ili int, posto se to koristi u zadatku. Naravno, trebalo bi za sve tipove.
            if (text == "System.Int32")
            {
                output = "integer";
            }
            else if (text == "System.String")
            {
                output = "string";
            }

            return output;
        }
    }
}
