using System;

namespace StringComparisonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "hello";
            string str3 = "Hello, World!";

            // Сравнение с помощью Compare
            Console.WriteLine("Compare str1 and str2: " + string.Compare(str1, str2)); // 1
            Console.WriteLine("Compare str1 and str2 (ignore case): " + string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase)); // 0

            // Сравнение с помощью Equals
            Console.WriteLine("Equals str1 and str2: " + str1.Equals(str2)); // False
            Console.WriteLine("Equals str1 and str2 (ignore case): " + str1.Equals(str2, StringComparison.OrdinalIgnoreCase)); // True

            // Сравнение с помощью CompareOrdinal
            Console.WriteLine("CompareOrdinal str1 and str2: " + string.CompareOrdinal(str1, str2)); // -32

            // Использование IndexOf
            Console.WriteLine("IndexOf 'World' in str3: " + str3.IndexOf("World")); // 7
            Console.WriteLine("IndexOf 'world' in str3 (ignore case): " + str3.IndexOf("world", StringComparison.OrdinalIgnoreCase)); // 7

            // Использование Contains
            Console.WriteLine("Contains 'Hello' in str3: " + str3.Contains("Hello")); // True
            Console.WriteLine("Contains 'hello' in str3 (ignore case): " + (str3.IndexOf("hello", StringComparison.OrdinalIgnoreCase) >= 0)); // True

            // Операторы == и !=
            Console.WriteLine("str1 == str2: " + (str1 == str2)); // False
            Console.WriteLine("str1 != str2: " + (str1 != str2)); // True
        }
    }
}

