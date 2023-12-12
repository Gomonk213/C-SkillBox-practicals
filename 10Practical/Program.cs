using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    internal class Program
    {
        static void ManagerMenu()
        {
            Manager manager = new Manager();
            
        }
        static void AssistantMenu()
        {
            Assistant assistant = new Assistant();
        }
        static void Main(string[] args)
        {
            
            
            int choice;
            while (true)
            {
                Console.WriteLine("Введите кто работает (1 - Консультант; 2 - Менеджер; другое - для выхода из программы)");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AssistantMenu();
                        break;
                    case 2:
                        ManagerMenu();
                        break;
                }
            }
        }
    }
}
