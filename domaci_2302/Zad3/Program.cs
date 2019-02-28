using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{


    //Napisati potprogram koji za proizvoljne brojeve a i b, 
    //ispisuje rezultat operacije čiji naziv je sadržan u promenljivoj operacija
    //(može da bude 'saberi', 'oduzmi', 'pomnozi', 'podeli'). 
    //Npr.ako je vrednost promenljive operacija ‘saberi’, ispisati rezultat a + b.Koristiti switch.


    class Program
    {
        enum OPERATIONS
        {
            ADDITION = 1,
            SUBTRACTION,
            MULTIPLICATION,
            DIVISION
        };

        static double Addition(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("Zbir brojeva je {0}.\n\n", Math.Round(c, 2));
            return c;            
        }

        static double Subtraction(double a, double b)
        {
            double c = a - b;
            Console.WriteLine("Razlika brojeva je {0}.\n\n", Math.Round(c, 2));
            return c;
        }

        static double Multiplication(double a, double b)
        {
            double c = a * b;
            Console.WriteLine("Proizvod brojeva je {0}.\n\n", Math.Round(c, 2));
            return c;
        }

        static double Division(double a, double b)
        {
            double c = a / b;
            Console.WriteLine("Kolicnik brojeva je {0}.\n\n", Math.Round(c, 2));
            return c;
        }

        static double CheckDouble(double a)
        {
            bool isItDouble;

            do
            {
                Console.WriteLine("Unesite broj: ");
                isItDouble = Double.TryParse(Console.ReadLine(), out a);
                if (!isItDouble)
                {
                    Console.WriteLine("Neispravan unos!");
                }
            } while (!isItDouble);

            return a;
        }

        static OPERATIONS CheckMenuIntAndConvertToOperationsEnum ()
        {
            bool isItInt;
            int a;

            do
            {
                Console.WriteLine("Unesite broj [0-4]: ");
                isItInt = Int32.TryParse(Console.ReadLine(), out a);
                if (!isItInt)
                {
                    Console.WriteLine("Neispravan unos! Probajte opet:");
                }
            } while (!isItInt || a < 0 || a > 4);

            OPERATIONS operation = (OPERATIONS)a;
            return operation;
        }

        static void MainMenu(double a, double b)
        {
            Console.WriteLine("izaberite racunsku operaciju pritiskom na broj: ");
            Console.WriteLine("1 - sabiranje");
            Console.WriteLine("2 - oduzimanje");
            Console.WriteLine("3 - mnozenje");
            Console.WriteLine("4 - deljenje");
            Console.WriteLine("0 - izlaz");
            Console.WriteLine();

            OPERATIONS operation = CheckMenuIntAndConvertToOperationsEnum();

            switch (operation)
            {
                case OPERATIONS.ADDITION: Addition(a, b); MainMenu(a, b); //Vracao sam na glavni meni radi lakseg testiranja.
                    break;
                case OPERATIONS.SUBTRACTION: Subtraction(a, b); MainMenu(a, b);
                    break;
                case OPERATIONS.MULTIPLICATION: Multiplication(a, b); MainMenu(a, b);
                    break;
                case OPERATIONS.DIVISION: Division(a, b); MainMenu(a, b);
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;

            a = CheckDouble(a);
            b = CheckDouble(b);

            MainMenu(a, b);       //Izlazni rezultat sam zaokruzio na dve decimale kod svake operacije da bi mi bilo lepse :))
        }
    }
}


