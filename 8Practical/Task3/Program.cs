using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,buf;
            HashSet<int> nums = new HashSet<int>();
            while (true)
            {
                Console.WriteLine("Введите число для добавления");
                num = int.Parse(Console.ReadLine());
                if (nums.TryGetValue(num, out buf))
                {
                    Console.WriteLine("Данное число уже было добавлено");
                    continue;
                }
                nums.Add(num);
                Console.WriteLine("Число успешно добавлено");
            }
        }
    }
}
