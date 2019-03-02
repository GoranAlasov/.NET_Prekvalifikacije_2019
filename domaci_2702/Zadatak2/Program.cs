using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
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

        static int[,] SwapRows(int numberOfRowBeingSwapped, int NumberOfRowSwappingTo, int[,] matrix)
        {
            int numberOfRows = matrix.GetLength(0);
            int numberOfColumns = matrix.GetLength(1);

            int[,] retVal = new int[numberOfRows,numberOfColumns];
            int[] rowBeingSwapped = new int[numberOfColumns];
            int[] rowSwappingTo = new int[numberOfColumns];

            for (int i = 0; i < numberOfColumns; i++)
            {
                rowBeingSwapped[i] = matrix[numberOfRowBeingSwapped - 1, i];
                rowSwappingTo[i] = matrix[NumberOfRowSwappingTo - 1, i];
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (i == numberOfRowBeingSwapped - 1)
                    {
                        retVal[i, j] = rowSwappingTo[j];
                    }
                    else if (i == NumberOfRowSwappingTo - 1)
                    {
                        retVal[i, j] = rowBeingSwapped[j];
                    }
                    else
                    {
                        retVal[i, j] = matrix[i, j];
                    }                    
                }
            }
            return retVal;
        }
        static int[,] SwapColumns(int numberOfColumnBeingSwapped, int numberOfColumnSwappingTo, int[,] matrix)
        {
            int numberOfRows = matrix.GetLength(0);
            int numberOfColumns = matrix.GetLength(1);

            int[,] retVal = new int[numberOfRows, numberOfColumns];
            int[] columnBeingSwapped = new int[numberOfRows];
            int[] columnSwappingTo = new int[numberOfRows];

            for (int i = 0; i < numberOfRows; i++)
            {
                columnBeingSwapped[i] = matrix[i, numberOfColumnBeingSwapped - 1];
                columnSwappingTo[i] = matrix[i, numberOfColumnSwappingTo - 1];
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (j == numberOfColumnBeingSwapped - 1)
                    {
                        retVal[i, j] = columnSwappingTo[i];
                    }
                    else if (j == numberOfColumnSwappingTo - 1)
                    {
                        retVal[i, j] = columnBeingSwapped[i];
                    }
                    else
                    {
                        retVal[i, j] = matrix[i, j];
                    }
                }
            }
            return retVal;
        }
        
        static void Main(string[] args)
        {
            int numberOfRows = MatrixNumberOfRowsOrColumnsCheck("redova", 20);
            int numberOfColumns = MatrixNumberOfRowsOrColumnsCheck("kolona", 20);

            int[,] matrix = PopulateMatrix(numberOfRows, numberOfColumns);

            WriteMatrix(matrix);

            Console.Read();
        }
    }
}
