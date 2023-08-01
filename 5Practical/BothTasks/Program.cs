using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BothTasks
{
    internal class Program
    {
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }
        static void PrintWords(string[] words)
        {
            foreach (string word in words) { Console.WriteLine(word); }
        }
        static string ReverseText(string text)
        {
            string Result="";
            string[] words=SplitText(text);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Result += words[i] + " ";
            }
            return Result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение для разделения на слова и изменения порядка слов");
            string text = Console.ReadLine();
            Console.WriteLine("Введённое предложение состоит из слов:");
            PrintWords(SplitText(text));
            Console.WriteLine("Введённое предложение в другом порядке: ");
            Console.WriteLine(ReverseText(text));
            Console.ReadKey();
        }
    }
}
