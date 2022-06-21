using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (IsYearLeap(year))
        {
            Console.WriteLine(year + " - високосный год");
        }
        else
        {
            Console.WriteLine(year + " - невисокосный год");
        }
        Console.Write("Введите значение температуры: ");
        double t = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение шкалы: ");
        string c = Console.ReadLine();
        Console.WriteLine("Результат: " + ConvertTemperature(t,c));
    }
    /*
     Напишите программу, которая осуществит проверку введённого года на високосность.
    Для прохождения проверки должно выполняться хотя бы одно из условий:
    Год делится на 4 без остатка, но не на 100.
    Год делится на 400 без остатка.

    Программа должна запрашивать значение года и выводить на экран ответ решение о том, является ли год високосным.
    Пример использования:

    >> Введите год: 1970
    >> 1970 - невисокосный год

    или:

    >> Введите год: 2000
    >> 2000 - високосный год

     */
    static bool IsYearLeap(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }
        return false;
    }

 /* Создайте конвертер градусов по шкале Цельсия в значения по шкале Фаренгейта и обратно. 
  * На ввод программа принимает два значения: 
  * температуру (число) и 
  * текущую шкалу (для Цельсия -- “C” или “c”, Фаренгейта -- “F” или “f”), 
  * на выходе даёт значение в шкале, отличающейся от введённой. 
  * 
  * Например:

>> Введите значение температуры: 22
>> Введите значение шкалы: С
>> Результат: 72F

Формулы преобразования между шкалами:
Цельсий-Фаренгейт: (t9)/5+32.
Фаренгейт-Цельсий: (t-32)5/9.
        */
    static string ConvertTemperature(double t, string temperatureScale)
    {
        if (temperatureScale == "F" || temperatureScale == "f")
        {
            return Convert.ToString(Math.Round((t - 32)*5/9)) + 'C';
        } 
        if (temperatureScale == "C" || temperatureScale == "c")
        {
            return Convert.ToString(Math.Round(t * 9/5 + 32)) + 'F';
        }
        return "";
    }




}







