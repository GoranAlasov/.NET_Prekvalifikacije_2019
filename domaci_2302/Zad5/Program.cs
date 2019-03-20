using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{


    //Napisati C# konzolnu aplikaciju koja za dati celi broj (integer) 
    //ispisuje poruku da li je broj jednocifren, dvocifren, ili trocifren.


    class Program
    {
        static int EnterAndCheckInt()
        {
            bool isItInt;
            int a;

            do
            {
                Console.WriteLine("Unesite jednocifren, dvoifren ili trocifren broj: ");
                isItInt = Int32.TryParse(Console.ReadLine(), out a);
                if (!isItInt || a < -999 || a > 999)
                {
                    Console.WriteLine("Neispravan unos! Pokusajte opet:");
                }
            } while (!isItInt || a < -999 || a > 999);

            return a;
        }

        static void CheckNumber(int number)
        {
            if (number > -10 && number < 10)
            {
                Console.WriteLine($"Unet broj {number} je jednocifren.");
            }
            else if ((number <= -10 && number > -100) || (number >= 10 && number < 100))
            {
                Console.WriteLine($"Unet broj {number} je dvocifren.");
            }
            else if ((number <= -100 && number > -1000) || (number >= 100 && number < 1000))
            {
                Console.WriteLine($"Unet broj {number} je trocifren.");
            }
        }

        static void Main(string[] args)
        {
            int a = EnterAndCheckInt();

            CheckNumber(a);
            //Da li postoji jos neki nacin za proveru ovoga koji ne ukljucuje ovakvo resenje kao sto sam dao u CheckNumber ili 
            //pravljenje kolekcije charova od ulaznog stringa (vec znamo da su u pitanju brojevi) i brojanje clanova te kolekcije?

            Console.ReadKey();
        }
    }
}
