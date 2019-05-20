using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    
    /*Napisati C# potprogram koja proverava da li su svi elementi datog niza brojeva u datom opsegu. 
      Ulazni parametri potprograma su niz, donja granica i gornja granica.
      Odlucio sam da vratim vrednosti koje ispadaju iz datog opsega, sto si napomenuo da moze dodatno da uradi ko zeli.*/
         
    class Program
    {
        static int[] CheckValueRangeOfArrayElements(int minValue, int maxValue, int[] array)
        {
            int[] retVal;
            int outOfRangeCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue || array[i] > maxValue)
                {
                    outOfRangeCounter++;
                }
            }

            retVal = new int[outOfRangeCounter];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < retVal.Length; j++)
                {
                    if (array[i] < minValue || array[i] > maxValue)
                    {
                        if (retVal[j] == 0) /*Nastaje problem kada je neki od clanova ulaznog niza 0, a kad je 0 istovremeno van dozvoljenog opsega.
                                             Uspeo sam resiti tako sto sam forsirao da je izlazni niz nullable (int?[]), pa onda u ovoj liniju proveravam
                                             da li je clan niza == null. Nisam hteo dalje da se igram s ovim, posto nismo ucili i nisam bas skroz siguran
                                             kako sve to radi.*/   
                        {
                            retVal[j] = array[i];
                            break;
                        }
                    }
                }                
            }

            return retVal;
        } //ovo resenje vraca niz onih vrednosti ulaznog niza koje su van opsega

        static bool AllArrayElementsInRange(int minValue, int maxValue, int[] array)
        {
            bool retVal = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue || array[i] > maxValue)
                {
                    retVal = false;
                }
            }
            return retVal;
        } //ovo resenje vraca bool vrednots da li su svi clanovi ulaznog niza u opsegu

        static void Main(string[] args)
        {
            //test vrednosti

            int[] array = new int[6] { 0, 1, 2, 3, 4, 5 };
            int[] array2 = CheckValueRangeOfArrayElements(2, 4, array);

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i]);
            }

            Console.WriteLine();
            Console.WriteLine(AllArrayElementsInRange(2, 4, array)); 
            Console.Read();
        }
    }
}
