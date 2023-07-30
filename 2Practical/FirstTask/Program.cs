using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Первая часть задания
            String fullName = "Иванов Пётр Сергеевич";
            int age = 12;
            string email = "petriva@mail.ru";
            double scoreIT = 93.2;
            double scoreMath = 98.9;
            double scorePhys = 67;
            string form = "Ф.И.О: {0} \nВозраст: {1} \nE-mail: {2} \nБаллы по:\n\nПрограммированию - {3}\nМатематике - {4}\nФизике - {5}";
            Console.WriteLine(form,fullName,age,email,scoreIT,scoreMath,scorePhys);
            //Вторая часть задания
            Console.WriteLine("Нажмите любую кнопу, чтобы получить сумму баллов");
            Console.ReadKey();
            double sum = scoreMath+scoreIT+scorePhys;
            Console.WriteLine($"Сумма баллов равна {sum}");
            Console.WriteLine("Нажмите любую кнопу, чтобы получить среднее арифметическое полученных баллов");
            Console.ReadKey();
            double average = sum / 3;
            Console.WriteLine($"Среднее арифметическое баллов равно {average:#.##}");
            Console.ReadKey();
        }
    }
}
