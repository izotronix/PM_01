using System;

namespace StringComparisonDemo
{
    class Program
    {
        static void Main()
        {
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "Hello";

            int compareResult = String.Compare(str1, str2);
            Console.WriteLine($"Compare(str1, str2): {compareResult}");

            bool isEqual = str1.Equals(str3);
            Console.WriteLine($"Equals(str1, str3): {isEqual}");

            int ordinalResult = String.CompareOrdinal(str1, str2);
            Console.WriteLine($"CompareOrdinal(str1, str2): {ordinalResult}");

            int index = str2.IndexOf('o');
            Console.WriteLine($"Индекс 'o' в 'World': {index}");

            bool contains = str1.Contains("ell");
            Console.WriteLine($"Содержит ли 'Hello' подстроку 'ell': {contains}");

            Console.WriteLine($"str1 == str3: {str1 == str3}");
            Console.WriteLine($"str1 != str2: {str1 != str2}");
        }
    }
}