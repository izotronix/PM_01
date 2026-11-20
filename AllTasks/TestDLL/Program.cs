using System;
using MyLibrary;
using ExternalLib;

namespace TestDLL
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== ТЕСТ 1: MyLibrary (внутри решения) ===\n");
            Class1 lib = new Class1();

            lib.SayHello("Admin");
            lib.ShowCurrentDate();

            int randomNum = lib.GetRandomNumber();
            Console.WriteLine($"Случайное число: {randomNum}");

            string textResult = lib.GetGreetingText();
            Console.WriteLine($"Текст: {textResult}");

            double area = lib.CalculateCircleArea(10.5);
            Console.WriteLine($"Площадь круга: {area:F2}");

            Console.WriteLine("\nНажмите клавишу для перехода ко второй библиотеке...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("=== ТЕСТ 2: ExternalLib (внешний DLL) ===\n");

            TemperatureConverter temp = new TemperatureConverter();


            temp.PrintCelsiusToFahrenheit(25);
            temp.PrintFahrenheitToCelsius(100);
            Console.WriteLine();

            double fahrenheit = temp.GetFahrenheit(-10);
            Console.WriteLine($"-10 °C в Фаренгейтах: {fahrenheit}");

            bool isFreezing = temp.IsFreezing(-5);
            Console.WriteLine($"При -5 °C замерзает вода? {isFreezing}");

            string desc = temp.GetWeatherDescription(22);
            Console.WriteLine($"Описание погоды при 22 °C: {desc}");

            Console.WriteLine("\nТестирование завершено. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}