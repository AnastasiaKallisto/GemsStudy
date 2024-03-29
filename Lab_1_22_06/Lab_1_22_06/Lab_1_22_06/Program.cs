﻿

using System;

class Program
{
    static void Main()
    {
        FindtheLongestWord();
        EagleAndTails();
    }

    /*Напишите программу, 
 * которая в пользовательском вводе отыскивает и запоминает самое длинное слово. 
 * Запрос ввода оформите в цикле, 
 * условием завершения работы цикла считайте ввод команды “exit”.
 * В конце работы программы выведите на экран самое длинное слово в верхнем регистре, 
 * а также покажите его длину. 
 * Пример работы программы:

>> Вводите слова, завершая каждое нажатием Enter.
>> Для выхода наберите "exit".
>>
>> кукуруза
>> бомбардир
>> синхрофазотрон
>> бобик
>> exit
>>
>> Считывание завершено.
>> Самое длинное слово: "СИНХРОФАЗОТРОН" (14).
*/
    static void FindtheLongestWord()
    {
        Console.WriteLine("Вводите слова, завершая каждое нажатием Enter. \nДля выхода наберите \"exit\".");
        string s = Console.ReadLine(); ;
        string theLongest = s;
        while (!s.Equals("exit"))
        {
            s = Console.ReadLine();
            if (s.Length > theLongest.Length)
            {
                theLongest = s;
            }
        }
        Console.WriteLine("Считывание завершено: \nСамое длинное слово: " + theLongest + ", длина слова - " + theLongest.Length);
    }
    /*Запрограммируйте игру “Орёл или решка”. В качестве “орла” считать число 1, “решки” -- 0, любой другой ввод пользователя считать командой к выходу из цикла. Обеспечьте подсчёт попаданий игрока и вывод счёта, а также показателя удачливости пользователя (отношения числа попаданий к общему числу попыток) в конце работы программы. Для реализации “задумывания” значения компьютером используйте функцию генерации псевдослучайных чисел.
Пример работы программы:

>> Игра началась!
>> Введите число: 1
>> Попробуйте снова
>> Введите число: 0
>> Угадали!
>> Введите число: 1
>> Угадали!
>> Введите число: 2
>> Игра окончена со счётом 2, угадано 66% бросков.
*/
    static void EagleAndTails()
    {
        Console.WriteLine("\n\nИгра с угадыванием чисел (0 или 1) началась!");
        int a = 0;
        int generatedNumber = 0;
        int wins = 0;
        int tries = 0;
        Random random = new Random();
        while (true)
        {
            generatedNumber = random.Next(2);
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            tries++;
            if (a == generatedNumber)
            {
                Console.WriteLine("Угадали!");
                wins++;
            } else if (a != 0 && a != 1)
            {
                tries--;
                Console.WriteLine($"Игра окончена со счетом {wins} из {tries}, угадано {Math.Round((double)wins*100/tries)}% бросков");
                break;
            } else
            {
                Console.WriteLine("Попробуйте снова");
            }
        }
    }

 




}