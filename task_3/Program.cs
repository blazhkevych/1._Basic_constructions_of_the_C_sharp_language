using System;

namespace task_3
{
    internal class Program
    {
        /*
         3. В цикле с клавиатуры вводятся 15 целых чисел. Необходимо найти 
            самую длинную неубывающую цепочку чисел. На экран вывести 
            найденную максимальную длину цепочки и порядковый номер того 
            числа, с которого цепочка началась.
         */
        // Не закончено, не работает !
        static void Main(string[] args)
        {
            int numbers = 15, i = 0, prevNumber = 0, startIndxOfBigger = 0, countNumbersInBigger = 0;
            Console.WriteLine("Введите 15 целых чисел: ");
            while (numbers > 0)
            {
                i++;
                Console.Write($"index {i} - ");
                int curNumber = Convert.ToInt32(Console.ReadLine());
                if (i == 1) // Если первое число скипаем и идем дальше.
                {
                    prevNumber = curNumber;
                    continue;
                }
                else
                {
                    if (prevNumber < curNumber)
                    {
                        startIndxOfBigger = i;
                        countNumbersInBigger++;
                    }
                    else
                    {

                    }
                }
                numbers--;
            }
            /*
             1234 653897542165382567
             */

        }
    }
}