using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    class Program
    {
        static string Invert(string text)
        {
            char[] textArray = text.ToArray();
            for (int i = 0; i < textArray.Length / 2; i++)
            {
                char temp = textArray[i];
                textArray[i] = textArray[textArray.Length - 1 - i];
                textArray[textArray.Length - 1 - i] = temp;
            }
            string retVal = new string(textArray);
            return retVal;
        }

        static bool Palyndrome(string text)
        {
            bool isPalyndrome = false;
            text = text.Replace(" ", "");

            string inverted = Invert(text);

            if (text == inverted)
            {
                isPalyndrome = true;
            }

            return isPalyndrome;
        }

        static void Main(string[] args)
        {
            string tekst = "ana voli milovana";

            bool x = Palyndrome(tekst);
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
