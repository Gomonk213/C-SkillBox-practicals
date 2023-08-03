using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Practical
{
    internal class Program
    {
        static bool Existance(string name)
        {
            if (File.Exists(name)){ return true; }
            else
            {
                Console.WriteLine("Файла с таким названием не существует, файл был создан");
                StreamWriter streamWriter = new StreamWriter(name);
                streamWriter.Close();
                return false;
            }
        }
        static void ReceiveRecord(string fileName)
        {
            StringBuilder result = new StringBuilder();
            string date= DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            
            Console.WriteLine("Введите ID");
            result.Append("\n" + Console.ReadLine() + "#" + date);

            Console.WriteLine("Введите ФИО");
            result.Append("#" + Console.ReadLine());
            
            Console.WriteLine("Введите возраст");
            result.Append("#" + Console.ReadLine());
            
            Console.WriteLine("Введите рост");
            result.Append("#" + Console.ReadLine());
            
            Console.WriteLine("Введите дату рождения");
            result.Append("#" + Console.ReadLine());
            
            Console.WriteLine("Введите место рождения");
            result.Append("#" + Console.ReadLine());
            
            Console.WriteLine("Запись успешно сформирована");

            AddRecord(fileName, result);
        }
        static void PrintFile(string name) 
        {
            //Console.WriteLine("ID | Дата и время добавления | Ф.И.О. | Возраст | Рост | Дата рождения | Место рождения");
            PrintText(File.ReadAllLines(name));
        }
        static void PrintText(string[] textLines)
        {
            foreach(string line in textLines)
            {
                if(line.IndexOf('#') != -1) 
                { 
                    PrintText(line.Split('#'));
                    Console.WriteLine();
                }
                else 
                {
                    Console.Write(line+" ");
                }
            }
        }
        static void AddRecord(string name,StringBuilder record)
        {
            StreamWriter streamWriter = new StreamWriter(@name, Existance(name));
            streamWriter.Write(record.ToString());
            streamWriter.Close();
        }
        static void Main(string[] args)
        {
            int option;

            string name;
            while (true)
            {
                
                Console.WriteLine("Введите название файла с расширением");
                name = Console.ReadLine();
                Console.WriteLine("Выберите желаемое действие:\n1. Вывести данные файла на экран\n2. Внести новую запись в файл");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        if (Existance(name)) { PrintFile(name); }
                        break;
                    case 2:
                        ReceiveRecord(name);
                        break;
                }
            }
        }
    }
}
