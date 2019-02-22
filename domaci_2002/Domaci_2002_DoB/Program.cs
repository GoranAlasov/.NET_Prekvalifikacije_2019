using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_2002_DoB
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DoB = new DateTime();
            bool isItDate;

            Console.WriteLine("Unesite datum u formatu mm/dd/gggg:");
            isItDate = DateTime.TryParse(Console.ReadLine(), out DoB);

            if (isItDate)
            {
                int year = DoB.Year;
                int month = DoB.Month;
                int day = DoB.Day;

                bool isItLeap;

                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    isItLeap = true;
                    Console.WriteLine("Osoba je rodjena u prestupnoj godini.");
                }
                else
                {
                    isItLeap = false;
                    Console.WriteLine("Osoba je rodjena u neprestupnoj godini.");
                }

                if (isItLeap == false)
                {
                    if (month == 2 && day > 28) // ova provera nema smisla posto klasa DateTime sama proveri 29. februar u neprestupnoj godini, ali imala bi smisla da ne koristim DateTime
                    {
                        Console.WriteLine("Februar ne moze da ima 29 dana u neprestupnoj godini.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Unet je neispravan datum.");
            }

            Console.ReadLine();
        }
    }
}
