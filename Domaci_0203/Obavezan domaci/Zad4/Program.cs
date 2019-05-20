using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{

    /*Napisati potprogram koji prihvata dva niza brojeva, a1 i a2, i vraća treći niz, a3, iste dužine kao a2, 
    čiji elementi predstavljaju broj puta koliko se svaki odgovarajući element a2 javlja u nizu a1.
    Drugim rečima, ako se prvi element niza a2 javlja četiri puta u nizu a1, prvi element a3 će biti 4. 
    Nizovi a1 i a2 ne moraju biti iste dužine.*/

    class Program
    {
        /*static int[] Counting(int[] array, int[] countThese)
        {            
            int[] counters = new int[countThese.Length];

            for (int i = 0; i < countThese.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (countThese[i] == array[j])
                    {
                        counters[i]++;
                    }
                }
            }
            return counters;
        }*/

        static void Main(string[] args)
        {
            //test podaci

            int[] checkingThisArray = new int[] { 1, 4, 5, 3, 6, 6, 7, 23, 23, 1, 6, 7};
            int[] countTheseInts = new int[] { 1, 88, 6, 88, 0, 23, 1};

            //int[] counters = Counting(checkingThisArray, countTheseInts); //primena potprograma iz zadatka

            int[] counters = checkingThisArray.Counting(countTheseInts); //koriscenje extension metode u Extensions.cs klasi

            for (int i = 0; i < counters.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("[ {0}, ", counters[i]);
                }
                else if (i == counters.Length - 1)
                {
                    Console.WriteLine("{0} ]", counters[i]);
                }
                else
                {
                    Console.Write("{0}, ", counters[i]);
                }
            }
            Console.Read();
        }
    }
}
