using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Practical
{
    internal class Program
    {
        
        static void Sorted(IOrderedEnumerable<Worker> workers)
        {
            Console.WriteLine("ID|Время создания записи|            Ф.И.О           |Возраст|Рост|Дата рождения|Место рождения");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.Print());
            }
        }
        static void SortRepo(Repository rep)
        {
            int option;
            Console.WriteLine("Выберите параметр для сортировки: \n1. Id\n2. Дата создания\n3. ФИО\n4. Возраст\n5. Рост\n6. Дата рождения\n7. Место рождения");
            option=int.Parse(Console.ReadLine());
            switch (option) 
            {
                case 1:
                    Sorted(rep.Workers.OrderBy(w => w.Id));
                    break;
                case 2:
                    Sorted(rep.Workers.OrderBy(w => w.AddingTime));
                    break;
                case 3:
                    Sorted(rep.Workers.OrderBy(w => w.FullName));
                    
                    break;
                case 4:
                    Sorted(rep.Workers.OrderBy(w => w.Age));
                    break;
                case 5:
                    Sorted(rep.Workers.OrderBy(w => w.Height));
                    break;
                case 6:
                    Sorted(rep.Workers.OrderBy(w => w.DateBirth));
                    break;
                case 7:
                    Sorted(rep.Workers.OrderBy(w => w.PlaceBirth));
                    break;
                default:
                    Console.WriteLine("Такого параметра нет");
                    break;
            }
        }
        static void OpenMenu()
        {
            Console.WriteLine("Выберите желаемую операцию:\n1. Вывод всех работников на экран\n2. Вывод работника под введённым id");
            Console.WriteLine("3. Добавить работника\n4. Удалить работника под введённым id\n5. Вывод работников созданных в определённом диапазоне дат");
            Console.WriteLine("6. Отсортировать всех работников по выбранному параметру");
        }
        static void Main(string[] args)
        {
            Worker buf;
            int choice,id;
            Repository db;
            DateTime date1, date2;
            Console.WriteLine("Введите путь к используемому файлу (Пример: Info\\Data.txt или Data.txt)");
            string path=Console.ReadLine();
            db=new Repository(path);
            while (true)
            {
                OpenMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        db.PrintWorkers();
                        break;
                    case 2:
                        Console.WriteLine("Введите id нужного работника");
                        id = int.Parse(Console.ReadLine());
                        if (db.GetWorkerById(id).Id == -1)
                            break;
                        Console.WriteLine(db.GetWorkerById(id).Print());
                        break;
                    case 3:
                        db.AddWorker();
                        break;
                    case 4:
                        Console.WriteLine("Введите id нужного работника");
                        id = int.Parse(Console.ReadLine());
                        db.DeleteWorker(id);
                        Console.WriteLine("Работник под id {0} удалён",id);
                        break;
                    case 5:
                        Console.WriteLine("Введите дату и время с какого времени взять записи (формат: дд-мм-гггг чч:мм)");
                        date1 = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Введите дату и время до какого времени взять записи (формат: дд-мм-гггг чч:мм)");
                        date2 = Convert.ToDateTime(Console.ReadLine());
                        db.PrintWorkersBetweenDates(date1,date2);
                        break;
                    case 6:
                        SortRepo(db);
                        break;
                    default:
                        Console.WriteLine("Выбрана неверная операция");
                        continue;
                }

            }
        }
    }
}
