using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad9
{


    //Unosite red po red teksta sve dok korisnik ne pritisne ESC, 
    //a onda napisite citav string (bonus: Pokusajte koristiti StringBuilder klasu)


    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder current = new StringBuilder();
            
            Console.WriteLine("Unosite tekst sve dok ne pritisnete ESC.");
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("**************************");
            Console.WriteLine();

            ConsoleKeyInfo key;

            do
            {                
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Escape)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        current.Append(Environment.NewLine);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(key.KeyChar);
                        current.Append(key.KeyChar);
                    }                    
                }
            } while (key.Key != ConsoleKey.Escape);            

            if (current.Length != 0)
            {                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Uneli ste sledeci tekst");
                Console.WriteLine();
                Console.WriteLine("-----------");
                Console.WriteLine(current);
            }
            else
            {
                Console.WriteLine("Niste uneli tekst!!");
            }
            Console.ReadLine();
        }
    }
}
