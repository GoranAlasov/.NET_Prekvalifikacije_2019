using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static int CountStringMatches(string[] array, string word)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (word == array[i])
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            string word = "red";
            string[] array = new[] {"red", "blue", "green", "red", "yellow" };

            int count = CountStringMatches(array, word); 08.03. 3am
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
