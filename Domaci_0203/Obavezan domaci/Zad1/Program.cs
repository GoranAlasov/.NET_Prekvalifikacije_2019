using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{

    /*Napisati C# potprogram koji datoj kvadratnoj matrici zameni izabrani red i kolonu.
    
    Napisao sam 3 potprograma: 
    1. zamena dva reda (recikliranje proslog domaceg :-)))
    2. zamena dve kolone (recikliranje proslog domaceg :-)))
    3. zamena reda i kolone - imao sam logicki problem, naveden u komentaru u telu potprograma*/

    class Program
    {
        static int[,] SwapTwoRows(int numberOfRowBeingSwapped, int NumberOfRowSwappingTo, int[,] matrix) 
        {
            int numberOfRows = matrix.GetLength(0);
            int numberOfColumns = numberOfRows;

            int[,] retVal = new int[numberOfRows, numberOfColumns];
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

        static int[,] SwapTwoColumns(int numberOfColumnBeingSwapped, int numberOfColumnSwappingTo, int[,] matrix) 
        {
            int numberOfRows = matrix.GetLength(0);
            int numberOfColumns = numberOfRows;

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

        static int[,] SwapRowWithColumn(int numberOfRowBeingSwapped, int numberOfColumnSwappingTo, int[,] matrix) 
            /*ne znam sta da uradim sa elementom na koordinati preseka reda i kolone koje zamenjujem
            po logickom sledu, trebalo bi definisati da li elemenat na preseku "pripada" koloni ili redu
            ja sam ga ostavio zakucanog kao deo kolone*/
        {
            int numberOfRows = matrix.GetLength(0);
            int numberOfColumns = numberOfRows; 

            int[,] retVal = new int[numberOfRows, numberOfColumns];
            int[] rowBeingSwapped = new int[numberOfColumns];
            int[] columnSwappingTo = new int[numberOfRows];

            for (int i = 0; i < numberOfColumns; i++)
            {
                rowBeingSwapped[i] = matrix[numberOfRowBeingSwapped - 1, i];
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                columnSwappingTo[i] = matrix[i, numberOfColumnSwappingTo - 1];
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (i == numberOfRowBeingSwapped - 1)
                    {
                        retVal[i, j] = columnSwappingTo[j];
                    }
                    if (j == numberOfColumnSwappingTo - 1 && i != numberOfRowBeingSwapped - 1)
                    {
                        retVal[i, j] = rowBeingSwapped[i];
                    }
                    if (j != numberOfColumnSwappingTo - 1 && i != numberOfRowBeingSwapped -1)
                    {
                        retVal[i, j] = matrix[i, j];
                    }                    
                }
            }
            return retVal;
        }


        static void Main(string[] args)
        {

            //podaci s kojima sam testirao

            int[,] matrica = new int [,] { { 3, 8, 4, 2 }, { 7, 3, 5, 6 }, { 1, 9, 9, 4 }, { 5, 8, 6, 1 } };

            //matrica = SwapTwoRows(1, 3, matrica);
            //matrica = SwapTwoColumns(2, 4, matrica);
            matrica = SwapRowWithColumn(3, 4, matrica);

            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    if (j == matrica.GetLength(1) - 1)
                    {
                        Console.WriteLine(matrica[i,j]);
                    }
                    else
                    {
                        Console.Write(matrica[i,j]);
                    }
                }
            }
            Console.Read();
        }
    }
}
