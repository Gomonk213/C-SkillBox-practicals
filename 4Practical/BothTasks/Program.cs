using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BothTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива (кол-во строк и столбцов)");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            Random rand= new Random();
            int sum = 0;
            Console.WriteLine($"Матрица A {rows} на {cols}:");
            int[,] matrixA = new int[rows, cols];
            for(int i=0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixA[i, j] = rand.Next(100);
                    Console.Write($"{matrixA[i, j],2} ");
                    sum += matrixA[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма элементов матрицы А - " + sum);
            Console.WriteLine($"Матрица B {rows} на {cols}:");
            int[,] matrixB = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixB[i, j] = rand.Next(100);
                    Console.Write($"{matrixB[i, j],2} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Матрица суммы А и В: ");
            int[,] matrixC = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i,j];
                    Console.Write($"{matrixC[i, j],3} ");
                }
            }
            Console.ReadKey();
        }
    }
}
