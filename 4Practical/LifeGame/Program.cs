using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buf;
            Random rand = new Random();
            bool[,] cell = new bool[50,50];
            for(int i = 0;i<cell.GetLength(0);i++) //Генерация поля
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    buf = rand.Next(2);
                    cell[i, j] = (buf == 0) ? false : true;
                }
            }
            Console.SetCursorPosition(0, Console.WindowTop);
            while (true)
            {
                for (int i = 0; i < cell.GetLength(0); i++) //Вывод поля на экран
                {
                    for (int j = 0; j < cell.GetLength(1); j++)
                    {
                        Console.Write(cell[i, j] ? "x" : " ");
                        if (j == cell.GetLength(1) - 1) Console.WriteLine("\r");

                    }
                }
                Console.SetCursorPosition(0, Console.WindowTop);
                Console.CursorVisible = false;

                int[,] calc=new int[cell.GetLength(0),cell.GetLength(1)];
                
                for (int i = 0; i < cell.GetLength(0); i++)//Проверка соседей на жизнь
                {
                    for (int j = 0;j < cell.GetLength(1); j++)
                    {
                        calc[i,j] = 0;
                        if(i==0)//первая строка
                        {
                            if (j == 0)//первый столбец
                            {
                                if (cell[i + 1, j]) calc[i, j]++;
                                if (cell[i, j + 1]) calc[i, j]++;
                                if (cell[i + 1, j + 1]) calc[i, j]++;
                            }
                            else if (j != cell.GetLength(1) - 1)//промежуточные столбцы
                            {
                                if (cell[i + 1, j - 1]) calc[i, j]++;
                                if (cell[i + 1, j + 1]) calc[i, j]++;
                                if (cell[i, j + 1]) calc[i, j]++;
                                if (cell[i + 1, j]) calc[i, j]++;
                                if (cell[i, j - 1]) calc[i, j]++;
                            }
                            else if (j == cell.GetLength(1) - 1)//последний столбец
                            {
                                if (cell[i + 1, j - 1]) calc[i, j]++;
                                if (cell[i + 1, j]) calc[i, j]++;
                                if (cell[i, j - 1]) calc[i, j]++;
                            }
                        }
                        else if(i!= cell.GetLength(0)-1) //промежуточные строки
                        {
                            if (j == 0)//первый столбец
                            {

                                if (cell[i - 1, j]) calc[i, j]++;
                                if (cell[i - 1, j + 1]) calc[i, j]++;
                                if (cell[i + 1, j]) calc[i, j]++;
                                if (cell[i, j + 1]) calc[i, j]++;
                                if (cell[i + 1, j + 1]) calc[i, j]++;
                            }
                            else if (j != cell.GetLength(1) - 1)//промежуточные столбцы
                            {
                                if (cell[i - 1, j]) calc[i, j]++;
                                if (cell[i, j - 1]) calc[i, j]++;
                                if (cell[i - 1, j - 1]) calc[i, j]++;
                                if (cell[i, j + 1]) calc[i, j]++;
                                if (cell[i + 1, j]) calc[i, j]++;
                                if (cell[i + 1, j +1]) calc[i, j]++;
                                if (cell[i - 1, j + 1]) calc[i, j]++;
                                if (cell[i + 1, j - 1]) calc[i, j]++;
                            }
                            else if(j == cell.GetLength(1) - 1)//последний столбец
                            {

                                if (cell[i - 1, j]) calc[i, j]++;
                                if (cell[i + 1, j]) calc[i, j]++;
                                if (cell[i, j - 1]) calc[i, j]++;
                                if (cell[i + 1, j - 1]) calc[i, j]++;
                                if (cell[i - 1, j - 1]) calc[i, j]++;
                            }
                        }
                        else if (i== cell.GetLength(0) - 1)//последняя строка
                        {
                            if (j == 0)//первый столбец
                            {
                                if (cell[i - 1, j]) calc[i, j]++;
                                if (cell[i, j + 1]) calc[i, j]++;
                                if (cell[i - 1, j + 1]) calc[i, j]++;
                            }
                            else if (j != cell.GetLength(1) - 1)//промежуточные столбцы
                            {
                                if (cell[i - 1, j - 1]) calc[i, j]++;
                                if (cell[i - 1, j]) calc[i, j]++;
                                if (cell[i - 1, j + 1]) calc[i, j]++;
                                if (cell[i, j + 1]) calc[i, j]++;
                                if (cell[i, j - 1]) calc[i, j]++;
                            }
                            else if (j == cell.GetLength(1) - 1)//последний столбец
                            {
                                if (cell[i - 1, j]) calc[i, j]++;
                                if (cell[i, j - 1]) calc[i, j]++;
                                if (cell[i - 1, j - 1]) calc[i, j]++;
                            }
                        }
                        
                    }
                }
                for (int i = 0; i < cell.GetLength(0); i++) //Процесс жизни
                {
                    for (int j = 0; j < cell.GetLength(1); j++)
                    {
                        if (!cell[i,j] && calc[i, j] == 3) { cell[i, j] = true; }
                        if (cell[i,j] && (calc[i, j] < 2 || calc[i, j] > 3)) { cell[i, j] = false; }
                    }
                }
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
