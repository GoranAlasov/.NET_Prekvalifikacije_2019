using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {        

        static int MatrixNumberOfRowsOrColumnsCheck (string text, int maximalValue)
        {
            int number = 0;
            bool numberOK = true;

            do
            {
                Console.WriteLine("Unesite broj {0} (maksimalno {1})", text, maximalValue);
                numberOK = Int32.TryParse(Console.ReadLine(), out number)
                    && number <= maximalValue
                    && number > 0;

                if (numberOK == false)
                {
                    Console.WriteLine("Neispravan unos probaj opet");
                }
            } while (numberOK == false);
            
            return number;
        }
        static int CheckMatrixCoordinatesInt(int i, int j)
        {
            int number = 0;
            bool numberOK = true;

            do
            {
                Console.WriteLine("Unesite [{0},{1}] elemenat matrice: ", (i + 1), (j + 1));
                numberOK = Int32.TryParse(Console.ReadLine(), out number);

                if (!numberOK)
                {
                    Console.WriteLine("Pogresan unos. Probaj opet: ");
                }
            } while (!numberOK);

            return number;
        }

        static void Main(string[] args)
        {            
            int numberOfRows = MatrixNumberOfRowsOrColumnsCheck("redova", 20);
            int numberOfColumns = MatrixNumberOfRowsOrColumnsCheck("kolona", 20);
            int maximalValue = Int32.MinValue;
            int minimalValue = Int32.MaxValue;

            int[,] matrix = new int[numberOfRows, numberOfColumns];

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    
                    matrix[i, j] = CheckMatrixCoordinatesInt(i, j);

                    if (matrix[i,j] > maximalValue)
                    {
                        maximalValue = matrix[i, j];
                    }

                    if (matrix[i,j] < minimalValue)
                    {
                        minimalValue = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Najmanji elemenat matrice je {0}, a najveci je {1}.", minimalValue, maximalValue);
            Console.Read();
        }
    }
}
