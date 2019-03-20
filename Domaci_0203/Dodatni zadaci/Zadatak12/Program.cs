using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak12
{
    class Program
    {
        static string SmurfText (string text)
        {
            string[] vowels =  { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < vowels.Length; i++)
            {
                text = text.Replace(vowels[i], "");
            }

            char[] charArray = text.ToArray();

            if (charArray[0] <= 'z' && charArray[0] >= 'a')
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }

            text = new string(charArray);

            return text;
        }

        static void Main(string[] args)
        {
            string text = "Ana voli Milovana.";

            Console.WriteLine(SmurfText(text));
        }
    }
}
