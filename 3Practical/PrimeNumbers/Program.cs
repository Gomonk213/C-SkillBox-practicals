using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool primeFactor=true;
            Console.WriteLine("Введите число на определение простоты");
            int number=int.Parse(Console.ReadLine());
            for (int i = 2; i * i <= number; i++)// идём от 2 до корня из числа
            {
                if (number % i == 0)
                {
                    primeFactor = false;
                }
            }
            if (primeFactor)
            {
                Console.WriteLine("Число является простым");
            }
            else { Console.WriteLine("Число не является простым"); }
            Console.ReadKey();
        }
    }
}
