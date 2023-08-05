using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Practical
{
    internal class Program
    {
        static void ShowAllWorkers(Repository workers)
        {

        }
        static void OpenMenu()
        {
            Console.WriteLine("Выберите желаемую операцию:\n1. Вывод всех работников на экран\n2. Вывод работника под введённым id");
            Console.WriteLine("3. Добавить работника\n4. Удалить работника под введённым id\n5.Вывод работников созданных в определённом диапазоне дат");
        }
        static void Main(string[] args)
        {
            Worker buf;
            int choice,id;
            Repository db;
            DateTime date1, date2;
            Console.WriteLine("Введите путь к используемому файлу (Пример: .\\Info\\Data.txt)");
            string path=Console.ReadLine();
            db=new Repository(path);
            while (true)
            {
                OpenMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowAllWorkers(db);
                        break;
                    case 2:
                        Console.WriteLine("Введите id нужного работника");
                        id = int.Parse(Console.ReadLine());
                        //buf = GetWorkerById(id);
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    default:
                        Console.WriteLine("Выбрана неверная операция");
                        continue;
                }

            }
        }
    }
}
