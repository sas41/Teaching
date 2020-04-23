using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //RandomMatrix2D();
            //RandomMatrix3D();
            AveragePerRow();

            Console.ReadLine();
        }

        static void RandomMatrix2D()
        {
            int[,] numberMatrix = new int[4, 3];
            Random rng = new Random();

            for (int row = 0; row < numberMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < numberMatrix.GetLength(1); col++)
                {
                    numberMatrix[row, col] = rng.Next(10, 30);
                }
            }

            for (int row = 0; row < numberMatrix.GetLength(0); row++)
            {
                Console.Write("{");
                for (int col = 0; col < numberMatrix.GetLength(1); col++)
                {
                    Console.Write(numberMatrix[row, col] + " ");
                }
                Console.WriteLine("}");
            }
        }
        static void RandomMatrix3D()
        {
            int[,,] numberMatrix = new int[4, 3, 2];

            Random rng = new Random();

            for (int x = 0; x < numberMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < numberMatrix.GetLength(1); y++)
                {
                    for (int z = 0; z < numberMatrix.GetLength(2); z++)
                    {
                        numberMatrix[x, y, z] = rng.Next(10, 30);
                    }
                }
            }

            for (int x = 0; x < numberMatrix.GetLength(0); x++)
            {
                Console.Write("{");
                for (int y = 0; y < numberMatrix.GetLength(1); y++)
                {
                    Console.Write("{");
                    for (int z = 0; z < numberMatrix.GetLength(2); z++)
                    {
                        Console.Write(numberMatrix[x, y, z] + " ");
                    }
                    Console.Write("} ");
                }
                Console.WriteLine("}");
            }
        }
        static void AveragePerRow()
        {
            int colCount = int.Parse(Console.ReadLine());
            int rowCount = int.Parse(Console.ReadLine());

            int[,] numbers = new int[rowCount, colCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    int current = int.Parse(Console.ReadLine());
                    numbers[row, col] = current;
                }
            }

            int currentRow = 0;

            for (int row = 0; row < rowCount; row++)
            {
                currentRow = 0;
                for (int col = 0; col < colCount; col++)
                {
                    currentRow += numbers[row, col] ;
                }
                double average = (double)currentRow / (double)colCount;
                Console.WriteLine($"Average of Row {row} is {average}");
            }

        }
        static void JaggedArray2D()
        {
            int[][] jaggedArray = {
                new int[] { 2, 8, 4, 6},
                new int[] { 3, 6},
                new int[] { 10, 20, 40}
            };
        }
        static void JaggedList2D()
        {
            List<List<int>> jaggedList = new List<List<int>>{
                new List<int> { 2, 8, 4, 6},
                new List<int> { 3, 6},
                new List<int> { 10, 20, 40}
            };
        }
    }
}
