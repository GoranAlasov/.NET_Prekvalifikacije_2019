using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad10
{


    //Napisati jednostavnu konzolnu aplikaciju(simulaciju aplikacije mobilnog operatera) koja omogućava korisniku da proveri trenutno stanje kredita, 
    //megabajta za internet i besplatnih minuta.Aplikaciju napustiti izborom opcije 0. 
    //(vrednosti koje ispisujete korisniku mogu da budu nasumične, po vašem izboru.Možete i da koristite Random klasu iz C#)


    //Nisam umeo da napravim main menu za pregledanje domaceg, zato sto nisam umeo da napravim referencu na drugi projekat iz ovog projekta i nisam
    //imao nista bolju ideju kako to da uradim ni posle pretrazivanja po internetu.



    class Program
    {
        static int CheckMenuInt()
        {
            bool isItInt;
            int a;

            do
            {
                Console.WriteLine("Unesite broj [0-9]: ");
                isItInt = Int32.TryParse(Console.ReadLine(), out a);
                if (!isItInt || a < 0 || a > 2)
                {
                    Console.WriteLine("Neispravan unos! Probajte opet:");
                }
            } while (!isItInt || a < 0 || a > 2);
            
            return a;
        }

        static void Credit(Random random)
        {
            Console.WriteLine("Vas kredit iznosi: {0} dinara.", random.Next(0, 5000) );
        }

        static void Internet(Random random)
        {
            Console.WriteLine("Vas preostali internet iznosi: {0} sati.", Math.Round((random.NextDouble() * 10), 2));
        }

        static void SwichCase(int menuItem)
        {
            Random random = new Random();

            switch (menuItem)
            {
                case 1: Credit(random); break;
                case 2: Internet(random); break;
                
                case 0: break;
                default:
                    break;
            }
        }        

        static void Main(string[] args)
        {
            Console.WriteLine("MENI MOBILNOG OPERATERA");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Provera kredita");
            Console.WriteLine("2 - Provera internet saobracaja");
            
            Console.WriteLine("0 - IZLAZ");
            Console.WriteLine();
            Console.WriteLine();

            int a = CheckMenuInt();
            SwichCase(a);
            Console.ReadLine();
        }
    }
}
