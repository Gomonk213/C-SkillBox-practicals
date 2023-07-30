using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности чисел");
            int length=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            int min=int.Parse(Console.ReadLine());
            int buf;
            for(int i=1; i<length; i++)
            {
                Console.WriteLine("Введите следующее число");
                buf = int.Parse(Console.ReadLine());
                min = (min < buf) ? min : buf;
            }
            Console.WriteLine("Минимальное число в последовательности - " + min);
            Console.ReadKey();        
        }
    }
}
