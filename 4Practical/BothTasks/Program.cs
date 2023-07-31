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
            Console.WriteLine($"Матрица {rows} на {cols}:");
            int[,] matrix = new int[rows, cols];
            for(int i=0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(100);
                    Console.Write($"{matrix[i, j],2} ");
                }
            }
            Console.ReadKey();
        }
    }
}
