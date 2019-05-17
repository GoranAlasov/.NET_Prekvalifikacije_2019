using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public static class Extensions
    {
        public static int[] Counting(this int[] array, int[] countThese)
        {
            int[] counters = new int[countThese.Length];

            for (int i = 0; i < countThese.Length; i++)
            {
                int current = countThese[i];

                counters[i] = current.NumberOfOccuranciesIn(array);
            }

            return counters;
        }

        public static int NumberOfOccuranciesIn(this int source, int[] array)
        {
            int numberOfOccurancies = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (source == array[i])
                {
                    numberOfOccurancies++;
                }
            }

            return numberOfOccurancies;
        }
    }
}
