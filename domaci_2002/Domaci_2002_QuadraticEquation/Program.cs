using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_2002_QuadraticEquation
{
    class Program
    {
        static void Linear (double b, double c)
        {
            double x1 = -c / b;
            Console.WriteLine("Jednacina je linearna i koristi metodu 1. Resenje je: " + x1);
        }

        static void DiscriminantPositive (double a, double b, double c, double d)
        {
            double x1 = (-b + Math.Sqrt(d) / 2 * a);
            double x2 = (-b - Math.Sqrt(d) / 2 * a);

            Console.WriteLine("Diskriminanta je pozitivna i koristi metodu 2. Resenja su " + x1 + " i " + x2 + ".");
        }

        static void DiscriminantZero (double a, double b, double c, double d)
        {
            double x1 = -(b / 2 * a);

            Console.WriteLine("Diskriminanta je jednaka nuli i koristi metodu 3. Resenje je " + x1);
        }

        static void DiscriminantNegative (double a, double b, double c, double d)
        {
            double i = Math.Sqrt(-1);

            double x1 = (-b / 2 * a) + ((Math.Sqrt(4 * a * c - b * b)) / 2 * a) * i;
            double x2 = (-b / 2 * a) - ((Math.Sqrt(4 * a * c - b * b)) / 2 * a) * i;

            Console.WriteLine("Diskriminanta je manja od nule i koristi metodu 4. Resenja su " + x1 + " i " + x2 + ".");
        }

        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            
            double x1 = 0;
            double x2 = 0;
            int equationType = 0;

            Console.WriteLine("RESAVANJE KVADRATNE JEDNACINE (a*x^2 + b*x + c = 0)\n\n\n");
            Console.WriteLine("Unesi promenljivu a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi promenljivu b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi promenljivu c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (a == 0)
            {
                equationType = 1;                
            }
            else
            {
                if (d > 0)
                {
                    equationType = 2;
                }
                else if (d == 0)
                {
                    equationType = 3;
                }
                else if (d < 0)
                {
                    equationType = 4;
                }
            }            

            switch (equationType)
            {
                case 1:
                    Linear(b, c);
                    break;
                case 2:
                    DiscriminantPositive(a, c, c, d);
                    break;
                case 3:
                    DiscriminantZero(a, b, c, d);
                    break;
                case 4:
                    DiscriminantNegative(a, b, c, d);
                    break;                    

                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
