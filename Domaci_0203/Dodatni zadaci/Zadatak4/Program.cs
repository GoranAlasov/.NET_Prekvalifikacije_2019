using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class Program
    {
        static bool CheckBrackets(string text)
        {
            bool bracketsOK;
            int bracketCounter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(' || text[i] == ')')
                {                   
                    if (text[i] == '(')
                    {
                        bracketCounter++;
                    }
                    else if (text[i] == ')')
                    {
                        bracketCounter--;

                        if (bracketCounter < 0)
                        {
                            bracketsOK = false;
                            return bracketsOK;
                        }
                    }                                       
                }                
            }

            if (bracketCounter != 0)
            {
                bracketsOK = false;
                return bracketsOK;
            }
            else
            {
                bracketsOK = true;
                return bracketsOK;
            }
        }

        static void Main(string[] args)
        {
            string text = "rr(((d)asds)())dasdsa";
            Console.WriteLine(CheckBrackets(text));
        }
    }
}
