using System;

namespace task_1
{
    internal class Program
    {
        /*
         1. Определить, является ли введённое число любой разрядности 
            палиндромом (например, 1234321 – палиндром, 12345 – не 
            палиндром). 
         */

        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Введите число: ");
                ulong number = Convert.ToUInt64(Console.ReadLine());

                ulong number_2 = 0;
                ulong temp = number;

                do
                {
                    number_2 = (number_2 * 10) + (number % 10);
                    number = number / 10;
                } while (number > 0); // Переворачиваем число.

                if (temp == number_2)
                    Console.WriteLine("Введенное число палиндром.");
                else
                    Console.WriteLine("Введенное число не палиндром.");

                Console.WriteLine("\nЕщё раз? д/н");
                answer = Console.ReadLine();
                Console.WriteLine();
            } while (answer == "д");
        }
    }
}