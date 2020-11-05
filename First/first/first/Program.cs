using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}.");
            Console.Write($"{name}, введи количество прожитых дней: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int year = (days - days % 365) / 365;
            int month = (days % 365 - days % 365 % 31) / 31;
            int day = days % 365 % 31;
            Console.WriteLine($"Вам {year} лет, {month} месяцев, {day} дней.");
            Console.ReadKey();

        }
    }
}
