using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    /*
     Чуть видоизменил блекджек, но у него есть проблемы в самой сути задачи (их трогать не стал), например адекватный "добор" карт,
     а не исходная последовательность карт
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount, sumCroupier, i, sum;//кол-во карт, сумма крупье, i, общая сумма номиналов карт игрока
            int iCroup;//Счетчик карт для крупье
            Random rand;
            int decision;
            string card;
            Console.WriteLine("Добро пожаловать!");
            //Объявления переменных вынес за цикл
            while (true)
            {
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("Хотите сыграть в \"21\" ?\n(1 - да, 0 - нет)");
                Console.WriteLine("_______________________________________________");
                decision = int.Parse(Console.ReadLine());
                if (decision==0)
                {
                    break;
                }
                sum = 0;
                rand = new Random();
                sumCroupier = rand.Next(4, 22);//Генерируем сумму у крупье (min = две двойки, max - блекджек)
                iCroup = 2;
                while(sumCroupier<17)//Крупье добирает карты пока его сумма <17
                {
                    //Существует два варианта вытянутого туза - 1 и 11, если сумма будет <=10, значит с тузом она станет <=21
                    // что удовлетворяет условию превращения туза в 11
                    if (sumCroupier <= 10)//Туз может быть 11
                    {
                        sumCroupier += rand.Next(2, 12);
                        iCroup++;
                    }
                    else//Туз только = 1
                    {
                        sumCroupier += rand.Next(1, 11);
                        iCroup++;
                    }
                }
                //Закончили с крупье
                Console.WriteLine("Уважаемый пользователь, сколько у вас на руках карт?");
                amount = int.Parse(Console.ReadLine());
                for (i = 0; i < amount; i++)
                {
                    Console.WriteLine("Введите номинал текущей карты");
                    card = Console.ReadLine();
                    switch (card)
                    {
                        case "K":
                        case "Q":
                        case "J":
                            sum += 10;
                            break;
                        case "T"://Снова вариации туза
                            if ((sum+11) <= 21)
                            {
                                sum += 11;
                            }
                            else
                            {
                                sum++;
                            }
                            break;
                        default: //Для численных номиналов
                            sum += int.Parse(card);
                            break;
                    }
                    if(sumCroupier==21 && iCroup==2 && i == 1 && sum!=21) //Если первые две карты игрока не дают 21, а у крупье за такое же количество карт - 21
                    {
                        Console.WriteLine("У крупье - блекджек, вы проиграли!");
                        break;
                    }
                }
                if(sumCroupier==21 && iCroup==2 && i == 1 && sum!=21)//Пред. случай из цикла
                {
                    continue;
                }
                Console.WriteLine($"Ваш счёт:{sum}\nСчёт крупье:{sumCroupier}");

                if ((sum > sumCroupier && sum<=21) || (sum<=21 && sumCroupier>21))
                {
                    Console.WriteLine("Вы победили!");
                }
                else  if((sum == sumCroupier && sum<=21))
                {
                    Console.WriteLine("Ничья!");
                }
                else
                { 
                    Console.WriteLine("Вы проиграли!"); 
                }
            }
        }
    }
}