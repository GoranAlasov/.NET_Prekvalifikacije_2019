using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class Program
    {
        static int CountVowels(string text)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u'};
            char[] textCharArray = text.ToArray();
            int countVowels = 0;

            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < textCharArray.Length; j++)
                {
                    if (vowels[i] == textCharArray[j])
                    {
                        countVowels++;
                    }
                }
            }

            return countVowels;
        }

        static void Main(string[] args)
        {
            string text = "ana voli milovana";
            int count = CountVowels(text);
            Console.WriteLine(count);
        }
    }
}
