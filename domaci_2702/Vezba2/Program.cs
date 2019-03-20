using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 20];
            int numberOfColumns;
            int numberOfRows;
            int sum = 0;
            double average;

            Console.WriteLine("Unesi broj redova");
            numberOfRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesi broj kolona:");
            numberOfColumns = Convert.ToInt32(Console.ReadLine());

            int [] rowSums = new int[numberOfRows];

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.WriteLine("Unesi vrednost matrice na koordinati [{0},{1}]", i + 1, j + 1);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                    rowSums[i] += matrix[i, j];
                    sum += rowSums[i];                    
                }                
            }

            average = sum / (numberOfColumns * numberOfRows);

            Console.WriteLine("Srednja vrednost svih clanova niza je {0}", average);

            for (int i = 0; i < rowSums.Length; i++)
            {
                Console.WriteLine("Zbir elemenata reda {0} je {1}.", i+1, rowSums[i]); 
            }

            Console.ReadLine();
        }
    }
}
