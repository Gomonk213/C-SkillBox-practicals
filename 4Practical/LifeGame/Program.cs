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
            bool[,] cell = new bool[20,50];
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
                int calc;
                for (int i = 0; i < cell.GetLength(0); i++)//Процесс жизни
                {
                    for (int j = 0;j < cell.GetLength(1); j++)
                    {
                        calc = 0;
                        if(i==0)//первая строка
                        {
                            if (j == 0)//первый столбец
                            {
                                if (cell[i + 1, j]) calc++;
                                if (cell[i, j + 1]) calc++;
                                if (cell[i + 1, j + 1]) calc++;
                            }
                            else if (j != cell.GetLength(1) - 1)//промежуточные столбцы
                            {
                                if (cell[i + 1, j - 1]) calc++;
                                if (cell[i + 1, j + 1]) calc++;
                                if (cell[i, j + 1]) calc++;
                                if (cell[i + 1, j]) calc++;
                                if (cell[i, j - 1]) calc++;
                            }
                            else//последний столбец
                            {
                                if (cell[i + 1, j - 1]) calc++;
                                if (cell[i + 1, j]) calc++;
                                if (cell[i, j - 1]) calc++;
                            }
                        }
                        else if(i!= cell.GetLength(0)-1) //промежуточные строки
                        {
                            if (j == 0)//первый столбец
                            {

                                if (cell[i - 1, j]) calc++;
                                if (cell[i - 1, j + 1]) calc++;
                                if (cell[i + 1, j]) calc++;
                                if (cell[i, j + 1]) calc++;
                                if (cell[i + 1, j + 1]) calc++;
                            }
                            else if (j != cell.GetLength(1) - 1)//промежуточные столбцы
                            {
                                if (cell[i - 1, j]) calc++;
                                if (cell[i, j - 1]) calc++;
                                if (cell[i - 1, j - 1]) calc++;
                                if (cell[i, j + 1]) calc++;
                                if (cell[i + 1, j]) calc++;
                                if (cell[i + 1, j +1]) calc++;
                                if (cell[i - 1, j + 1]) calc++;
                                if (cell[i + 1, j - 1]) calc++;
                            }
                            else//последний столбец
                            {

                                if (cell[i - 1, j]) calc++;
                                if (cell[i + 1, j]) calc++;
                                if (cell[i, j - 1]) calc++;
                                if (cell[i + 1, j - 1]) calc++;
                                if (cell[i - 1, j - 1]) calc++;
                            }
                        }
                        else//последняя строка
                        {
                            if (j == 0)//первый столбец
                            {
                                if (cell[i - 1, j]) calc++;
                                if (cell[i, j + 1]) calc++;
                                if (cell[i - 1, j + 1]) calc++;
                            }
                            else if (j != cell.GetLength(1) - 1)//промежуточные столбцы
                            {
                                if (cell[i - 1, j - 1]) calc++;
                                if (cell[i - 1, j]) calc++;
                                if (cell[i - 1, j + 1]) calc++;
                                if (cell[i, j + 1]) calc++;
                                if (cell[i, j - 1]) calc++;
                            }
                            else//последний столбец
                            {
                                if (cell[i - 1, j]) calc++;
                                if (cell[i, j - 1]) calc++;
                                if (cell[i - 1, j - 1]) calc++;
                            }
                        }
                        if (cell[i,j]==false && calc==3)//три живых вокруг мёртвой
                        {
                            cell[i,j] = true;
                        }
                        if (cell[i,j]==true && (calc<2 | calc>3))//меньше 2 или больше 3 вокруг живой клетки
                        {
                            cell[i, j] = false;
                        }
                    }
                }
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
