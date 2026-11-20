using System;

namespace PR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. Демонстрация try-catch-finally ===");
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            finally
            {
                Console.WriteLine("Блок finally выполняется всегда");
            }

            Console.WriteLine("\n=== 2. Фильтры исключений (when) ===");
            int a = 2;
            int b = 0;

            try
            {
                int result1 = a / b;
                int result2 = b / a;
            }
           
            catch (DivideByZeroException) when (b == 0)
            {
                Console.WriteLine("Фильтр: y не должен быть равен 0!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n=== 3. Обработка ввода пользователя (Свойства Message и TargetSite) ===");
            try
            {
                Console.Write("Введите число для проверки: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine($"Вы ввели: {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\n[Ошибка] Неверный формат!");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"TargetSite: {ex.TargetSite}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Другая ошибка: {ex.Message}");
            }

            Console.WriteLine("\n=== 4. Обработка выхода за границы массива ===");
            try
            {
                int[] array = { 1, 2, 3 };
                Console.WriteLine(array[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("[Ошибка] Индекс находится вне диапазона массива!");
                Console.WriteLine($"Message: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"[Ошибка] Недопустимое значение аргумента: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}