using System;

namespace Lab_15
{
    internal class Program
    {
        private static void EvaluateNumber(double n)
        {
            Console.WriteLine($"Number: {n}");
            Console.WriteLine($"Integer part: {(int)n}");
            Console.WriteLine($"Fractional part: {n - (int)n}");
            Console.WriteLine($"Square: {n*n}");
            Console.WriteLine($"Cube: {n*n*n}");
            Console.WriteLine($"Square root: {Math.Sqrt(n)}");
        }

        private static void SwapStrings(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        private static void TestStrings()
        {
            Console.WriteLine("\nTesting strings:");
            string s1 = "a";
            string s2 = "b";
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            SwapStrings(ref s1, ref s2);
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
        }

        public static void Main()
        {
            Console.Write("Enter the number -> ");
            double n = Convert.ToDouble(Console.ReadLine());
            EvaluateNumber(n);
            TestStrings();
        }
    }
}
