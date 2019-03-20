using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum = 50;
            int sum = 0;
            int positionOfMaxum = 0;
            int valueOfMaximum = int.MinValue;

            Console.WriteLine("Unesi broj elemenata niza brojeva: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[maximum];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Unesite {0} element niza: ", (i+1));
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
                //sum = array.Sum(); 

                if (array[i] > valueOfMaximum)
                {
                    valueOfMaximum = array[i];
                    positionOfMaxum = i + 1;                    
                }
            }                  

            Console.WriteLine("Pozicija maksimalnog elementa niza je {0}, a on iznosi {1}.", positionOfMaxum, valueOfMaximum);
            Console.ReadLine();            
        }
    }
}
