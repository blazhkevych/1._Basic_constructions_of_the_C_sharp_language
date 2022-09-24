using System;

namespace task_2
{
    internal class Program
    {
        /*
         2. Осуществить циклический сдвиг введённого числа на N разрядов. 
            Направление сдвига задает пользователь. Например, при сдвиге 
            числа 12345 влево на 3 разряда получится число 45123. При сдвиге 
            числа 12345 вправо на 3 разряда получится число 34512. 
         */
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Введите число N: ");
                string number = Console.ReadLine();

                Console.WriteLine("На сколько разрядов осуществлять сдвиг ?");
                int shift = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Выберите направление сдвига:");
                Console.WriteLine("1 сдвиг влево <---");
                Console.WriteLine("2 сдвиг вправо --->");

                int switch_on = Convert.ToInt32(Console.ReadLine());

                switch (switch_on)
                {
                    case 1:                                          // 1 сдвиг влево <---
                        shift %= number.Length;
                        string res1 = number.Substring(shift) + number.Substring(0, shift);
                        int res11 = Convert.ToInt32(res1);
                        Console.WriteLine(res11);
                        break;
                    case 2:                                         // 2 сдвиг вправо --->
                        shift %= number.Length;
                        string res2 = number.Substring(number.Length - shift) + number.Substring(0, number.Length - shift);
                        int res22 = Convert.ToInt32(res2);
                        Console.WriteLine(res22);
                        break;
                }
                Console.WriteLine("\nЕщё раз? д/н");
                answer = Console.ReadLine();
                Console.WriteLine();
            } while (answer == "д");
        }
    }
}