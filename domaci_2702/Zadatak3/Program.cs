using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static int MatrixNumberOfRowsOrColumnsCheck(string text, int maximalValue)
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
        static int[,] PopulateMatrix(int numberOfRows, int numberOfColumns)
        {
            int[,] retVal = new int[numberOfRows, numberOfColumns];

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    retVal[i, j] = CheckMatrixCoordinatesInt(i, j);
                }
            }

            return retVal;
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
        static void WriteMatrix(int[,] matrix)
        {
            int numberOfRows = matrix.GetLength(0);
            int numberOfColumns = matrix.GetLength(1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ispis matrice");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (j == numberOfColumns - 1)
                    {
                        Console.WriteLine("   {0}", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("  {0}  ", matrix[i, j]);
                    }
                }
            }
        }

        static int SumMainDiagonal (int[,] matrix)
        {
            int retVal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        retVal += matrix[i, j];

                    }
                }
            }

            return retVal;
        }
        static int SumAltDiagonal (int[,] matrix)
        {
            int retVal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (((i + 1) + (j + 1)) == (matrix.GetLength(0) + 1))
                    {
                        retVal += matrix[i, j];
                    }
                }
            }


            return retVal;
        }

        static double AvgMainDiagonal (int[,] matrix)
        {
            double sum = 0;
            double retVal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            retVal = sum / matrix.GetLength(0);
            return Math.Round(retVal, 2);
        }
        static double AvgAltDiagonal(int[,] matrix)
        {
            double sum = 0;
            double retVal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (((i + 1) + (j + 1)) == (matrix.GetLength(0) + 1))
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            retVal = sum / matrix.GetLength(0);
            return Math.Round(retVal, 2);
        }
        
        static void Main(string[] args)
        {
            int numberOfRowsAndColumns = MatrixNumberOfRowsOrColumnsCheck("redova i kolona", 30);            

            int[,] matrix = PopulateMatrix(numberOfRowsAndColumns, numberOfRowsAndColumns);
            WriteMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zbir clanova glavne dijagonale matrice je {0}, a zbir clanova sekundarne dijagonale je {1}.", SumMainDiagonal(matrix), SumAltDiagonal(matrix));
            Console.WriteLine("Srednja vrednost clanova glavne dijagonale matrice je {0}, a srednja vrednost clanova sekundarne dijagonale je {1}.",
                AvgMainDiagonal(matrix), AvgAltDiagonal(matrix));
            Console.Read();
        }
    }
}
