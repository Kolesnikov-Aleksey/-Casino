using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp45
{
    class Program
    {
        public static int CHOICE(int value)
        {
            bool check = true;
            while (check == true)
            {
                if (value>2||value<1)
                {
                    Console.WriteLine("Неверное значение, введите снова");
                    string sr = Console.ReadLine();
                    value = incorrect_value(sr);
                }
                else { check = false; }
            }
            return (value);
        }//функция для проверки выбора: 1 или 2
        public static int incorrect_value(string value)
        {
            bool check = true;
            while (check == true)
            {
                try
                {
                    Convert.ToInt32(value);
                    check = false;
                }
                catch
                {
                    Console.WriteLine("Данные введены некорректно, введите снова");
                    value = Console.ReadLine();
                }
            }
            int number = Convert.ToInt32(value);

            return (number);
        }//фун-я для проверки на корректность данных
        public static int Player_number(int value)
        {
            bool check = true;
            while (check == true)
            {
                if (value > 3 || 0 > value)
                {
                    Console.WriteLine("Неверное значение, введите снова");
                    string sr = Console.ReadLine();
                    value = incorrect_value(sr);
                }
                else { check = false; }
            }
            return (value);
        }//ф-я для проверки номера, выбранного пользователем
        static void Main(string[] args)
        {
            string choice, bet, player_number;
            int victory = 0, Choice, count = 1000;
            Console.WriteLine("Ваш счёт :" + count + "\n1-сделать ставку и сыграть\n" + "2-отказаться\n ");
            choice = Console.ReadLine();
            Choice = CHOICE(incorrect_value(choice));
            {
                while (Choice == 1 && count > 0)
                {
                    Console.WriteLine("Введите ставку");
                    bet = Console.ReadLine();
                    int BET = incorrect_value(bet);
                    if (BET >= 0 && BET <= count)
                    {
                        Random rnd = new Random();
                        int number = rnd.Next(1, 4);
                        
                        Console.WriteLine("Выберите число от 1 до 3");
                        player_number = Console.ReadLine();
                        if (number == Player_number(incorrect_value(player_number)))
                        {
                            count = count + BET;
                            Console.WriteLine("Вы угадали число");
                            victory++;
                        }
                        else
                        {
                            count = count - BET;
                            Console.WriteLine("Вы проиграли");
                        }
                        Console.WriteLine("Ваш счёт:" + count + "\nПобед:" + victory + "\n1-Сделать ставку и сыграть ещё раз\n" + "2-забрать деньги\n ");
                        choice = Console.ReadLine();
                        Choice = CHOICE(incorrect_value(choice));
                    }
                }
            }
            if (count <= 0)
            {
                Console.WriteLine("Вы всё проиграли, у вас нет денег, чтобы продолжить игру");
            }
            else
            {
                Console.WriteLine("Вы закончили игру");
            }
            Console.ReadLine();
        }
    }
}
