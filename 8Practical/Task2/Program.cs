using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void FillBook(Dictionary<string,string> phoneBook)
        {
            string phone, fullName;
            Console.WriteLine("Введите номер телефона");
            phone = Console.ReadLine();
            while (phone != "")
            {
                if (phoneBook.TryGetValue(phone, out string fn))
                {
                    Console.WriteLine("Такой телефон уже есть в книге");
                    Console.WriteLine("Введите номер телефона");
                    phone = Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Введите ФИО владельца");
                fullName = Console.ReadLine();
                phoneBook.Add(phone, fullName);
                Console.WriteLine("Введите номер телефона");
                phone = Console.ReadLine();
            }
        }
        static void PrintBook(Dictionary<string,string> book)
        {
            Console.WriteLine("Телефонная книжка: ");
            foreach (KeyValuePair<string,string> pair in book)
            {
                Console.WriteLine("{0} - {1}", pair.Key,pair.Value);
            }
        }
        static void FindByPhone(Dictionary<string,string> book,string phone) 
        {
            if (book.TryGetValue(phone, out string fn))
            {
                Console.WriteLine($"Владелец {phone} - " + fn);
            }
            else
            {
                Console.WriteLine("Такого номера нет в книжке");
            }
        }
        static void Main(string[] args)
        {
            string phone;
            Dictionary<string,string> PhoneBook = new Dictionary<string,string>();
            FillBook(PhoneBook);
            PrintBook(PhoneBook);
            Console.WriteLine("Введите необходимый номер телефона (формат без +)");
            phone = Console.ReadLine();
            FindByPhone(PhoneBook, phone);
            Console.ReadKey();
        }
    }
}
