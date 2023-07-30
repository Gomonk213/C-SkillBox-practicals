using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для определения чётности");
            int number=int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Введенное число - четное");
            }
            else
            {
                Console.WriteLine("Введенное число - нечетное");
            }
            Console.ReadKey();
        }
    }
}
