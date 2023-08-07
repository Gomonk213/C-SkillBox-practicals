using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Fill(List<int> nums)
        {
            Random rand = new Random();
            for(int i = 0; i < 10; i++) //10 элементов для удобства, можно и 100 как в задании
            {
                nums.Add(rand.Next(0,101));
            }
        }
        static void Print(List<int> nums) 
        {
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        static void DeleteNums(List<int> nums)
        {
            for(int i=0; i < nums.Count; i++)
            {
                if (nums[i] > 25 && nums[i] < 50)
                {
                    nums.RemoveAt(i);
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Fill(numbers);
            Console.WriteLine("До удаления");
            Print(numbers);
            DeleteNums(numbers);
            Console.WriteLine("После удаления");
            Print(numbers);
            Console.ReadKey();
        }
    }
}
