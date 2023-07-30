using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное число для генерации");
            int max=int.Parse(Console.ReadLine());
            Random rand = new Random();
            int number=rand.Next(max);
            Console.WriteLine("Сгенерировано число от 0 до " + max+". Угадывайте! (Для выхода введите -1)");
            int predict=int.Parse(Console.ReadLine());
            while (predict != -1)
            {
                if (predict == number)
                {
                    Console.WriteLine("Верно! Загаданное число - " + number);
                    break;
                }
                else if (predict < number)
                {
                    Console.WriteLine("Загаданное число больше! Попробуйте ещё раз");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше! Попробуйте ещё раз");
                }
                predict = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Нажмите любую кнопку для выхода из программы");
            Console.ReadKey();
        }
    }
}
