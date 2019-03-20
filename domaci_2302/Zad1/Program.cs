using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{


    //Napisati C# konzolnu aplikaciju koja kreira promenljive a i b i dodeljuje im vrednosti 6 i 8. 
    //Ako je zbir ovih vrednosti veći od 10, ispisati zbir promenljivih, u suprotnom ispisati njihovu razliku. Koristiti if/else.


    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMessage(6, 4);
        }

        //Razumem da nije po specifikaciji zadatka, ali zeleo sam da napravim metodu koja vrsi proveru za bilo koja dva int-a

        static void ConsoleMessage(int a, int b)
        {
            int zbir = a + b;

            if (zbir > 10)
            {
                Console.WriteLine($"Zbir promenjivuh je veci od 10 i iznosi {zbir}.");
            }
            else
            {
                int razlika = a - b;
                Console.WriteLine($"Zbir promenljiih je manji od 10, a njihova razlika je {razlika}.");
            }
            Console.ReadLine();
        }
    }
}
