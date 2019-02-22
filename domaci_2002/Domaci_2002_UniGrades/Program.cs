using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_2002_UniGrades
{
    class Program
    {
        static void OutputGrade (int grade)
        {
            switch (grade)
            {
                case 5:
                    Console.WriteLine($"Dobio si {grade}.");
                    break;
                case 6:
                    Console.WriteLine($"Dobio si {grade}.");
                    break;
                case 7:
                    Console.WriteLine($"Dobio si {grade}.");
                    break;
                case 8:
                    Console.WriteLine($"Dobio si {grade}.");
                    break;
                case 9:
                    Console.WriteLine($"Dobio si {grade}.");
                    break;
                case 10:
                    Console.WriteLine($"Dobio si {grade}.");
                    break;
                default:
                    break;
            }
        }

        static int PointsToGrade (int points)
        {
            int grade = 0;

            if (points < 0)
            {
                Console.WriteLine("Broj poena je manji od 0.");                
            }
            else if (points > 100)
            {
                Console.WriteLine("Broj poena je veci od 100.");                                
            }
            else if (points < 0 && points < 55)
            {
                grade = 5;                
            }
            else if (points > 55 && points <= 64)
            {
                grade = 6;
            }
            else if (points > 65 && points <= 74)
            {
                grade = 7;
            }
            else if (points > 75 && points <= 84)
            {
                grade = 8;
            }
            else if (points > 85 && points <= 95)
            {                
                grade = 9;
            }
            else if (points > 95 && points <= 100)
            {
                grade = 10;
            }

            return grade;
        }

        static void Main(string[] args)
        {
            int points;
            int grade;

            Console.WriteLine("Unesite broj poena [0-100]: ");

            bool isItNumber = int.TryParse(Console.ReadLine(), out points);

            if (isItNumber)
            {
                grade = PointsToGrade(points);
                OutputGrade(grade);
            }
            else
            {
                Console.WriteLine("Niste uneli broj!");
            }

            Console.WriteLine("Pritisnite bilo koji taster za kraj aplikacije");
            Console.ReadKey();
        }            
    }
}
