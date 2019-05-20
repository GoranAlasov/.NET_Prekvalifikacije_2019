using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak11
{
    class Program
    {
        enum daysOfTheWeek { subota, nedelja, ponedeljak, utorak, sreda, cetvrtak, petak };        

        static bool LeapYear (int year)
        {
            bool retVal;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                retVal = true;                
            }
            else
            {
                retVal = false;
            }

            return retVal;
        }

        static int EnterInt(int minValue, int maxValue)
        {
            bool numberOk;
            int number;            

            do
            {
                numberOk = Int32.TryParse(Console.ReadLine(), out number) 
                    && number >= minValue 
                    && number <= maxValue;

                if (!numberOk)
                {
                    Console.WriteLine("Neispravna vrednost, pokusajte opet: ");
                }
            } while (!numberOk);

            return number;
        }

        static void CalculateDay()
        {
            Console.Write("Unesite godinu: "); 
            int year = EnterInt(Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("Unesite mesec: ");
            int month = EnterInt(1, 12);
            int day = 0;

            Console.WriteLine("Unesite dan: ");
            if (month == 1 || month == 3 || month == 5 || month ==7 || month == 8 || month == 10 || month == 12)
            {
                day = EnterInt(1, 31);
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                day = EnterInt(1, 30);
            }
            else if (month == 2 && LeapYear(year) == false)
            {
                day = EnterInt(1, 28);
            }
            else if (month == 2 && LeapYear(year) == true)
            {
                day = EnterInt(1, 29);
            }

            if (month == 1)
            {
                month = 13;
                year -= 1;
            }

            if (month == 2)
            {
                month = 14;
                year -= 1;
            }

            int century = year / 100;
            int yearInCentury = year % 100;


            int resultingDay = (day + ((26 * (month + 1)) / 10) + yearInCentury + (yearInCentury / 4) + (century / 4) + (5 * century)) % 7;

            daysOfTheWeek dayRes = (daysOfTheWeek)resultingDay;

            Console.WriteLine("Tog datuma je bio dan {0}.", dayRes);
        }

        static void Main(string[] args)
        {
            CalculateDay();
            Console.ReadLine();
        }
    }
}
