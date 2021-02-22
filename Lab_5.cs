using System;
using System.Linq;

namespace Lab_5
{
    internal class Program
    {
        private static int[] FillArray(string method, int length)
        {
            int randomBoundary = length;
            length = Math.Abs(length);
            int[] arr = new int[length];
            switch (method)
            {
                case "random":
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    for (int i = 0; i < length; ++i)
                    {
                        if (randomBoundary > 0)
                        {
                            arr[i] = rand.Next(0, randomBoundary);
                        }
                        else
                        {
                            arr[i] = rand.Next(randomBoundary, 0);
                        }
                    }
                    break;
                case "keyboard":
                    for (int i = 0; i < length; ++i)
                    {
                        Console.Write("Введiть {0}-й елемент -> ", i);
                        int input = Convert.ToInt32(Console.ReadLine());
                        arr[i] = input;
                    }
                    break;
                case "literal":
                    for (int i = 0; i < length; ++i)
                    {
                        arr[i] = i + 1;
                    }
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(i == arr.Length - 1 ? "{0}" : "{0}, ", arr[i]);
            }
            Console.Write("]\n");
        }

        public static void Main()
        {
            // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Знайти суму, добуток елементів масиву С[1..19]. Елементи масиву вводимо трьома способами.
            int[] arr = FillArray("literal", 18);
            PrintArray(arr);
            int sum = arr.Sum();
            long mul = 1;
            foreach (int i in arr)
            {
                mul *= i;
            }

            Console.WriteLine("Сума:{0}, добуток:{1}\n", sum, mul);

            // 2. Знайти добуток кожного елементу масиву А[0..10]. Тобто елемент масиву дорівнює х, знайти х^2.
            int[] arr2 = FillArray("random", 10);
            PrintArray(arr2);
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr2[i] = arr2[i] * arr2[i];
            }

            PrintArray(arr2);
            Console.WriteLine();

            // 3. Знайти мінімальний і максимальний елементів масиву С[1..19] і поміняти їх місцями
            // Елементи масиву вводимо трьома способами (літералами, з клавіатури, методом випадкових чисел).
            int[] arr3 = FillArray("random", 18);
            PrintArray(arr3);
            int max = arr3.Max();
            int min = arr3.Min();
            for (int i = 0; i < arr3.Length; ++i)
            {
                if (arr3[i] == max)
                {
                    arr3[i] = min;
                }
                else if (arr3[i] == min)
                {
                    arr3[i] = max;
                }
            }

            PrintArray(arr3);
            Console.WriteLine();

            // 4. Задати масив С[5..79], відсортувати. Вивести суму  парних елементів.  
            int[] arr4 = FillArray("random", 74);
            Array.Sort(arr4);
            foreach (int i in arr4)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\n");

            // 5. Задати масив С[0..20], відсортувати. Вивести суму  елементів С[5] i C[7].
            int[] arr5 = FillArray("random", 20);
            Array.Sort(arr5);
            PrintArray(arr5);
            Console.WriteLine("Сума: {0}\n", arr5[5] + arr5[7]);
            
            // 6. Задати масив С[5..25], відсортувати. Вивести добуток всіх елементів, які діляться на 5.
            int[] arr6 = FillArray("random", 20);
            Array.Sort(arr6);
            PrintArray(arr6);
            mul = 1;
            foreach (int i in arr6)
            {
                if (i % 5 == 0 && i != 0)
                {
                    mul *= i;
                }
            }
            Console.WriteLine("Добуток: {0}\n", mul);
            
            // 7. Знайти середнє арифметичне значення елементів масиву С[1..23]
            int[] arr7 = FillArray("literal", 22);
            PrintArray(arr7);
            Console.WriteLine("Середнє арифметичне: {0}\n", arr7.Average());
            
            // 8. Записати на місці відємних елементів масиву С[1..-15] нулі, і виведіть їх на екран.
            int[] arr8 = FillArray("random", -14);
            PrintArray(arr8);
            for (int i = 0; i < arr8.Length; ++i)
            {
                if (arr8[i] < 0)
                {
                    arr8[i] = 0;
                }
            }
            PrintArray(arr8);
            Console.WriteLine();
            
            // 9. Дано одновимірний масив цілих чисел А[i], де i = 1,2,…n. Вивести елементи масиву з непарними індексами.
            int[] arr9 = FillArray("literal", 20);
            PrintArray(arr9);
            for (int i = 0; i < arr9.Length; ++i)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", arr9[i]);
                }
            }
            Console.WriteLine("\n");
            
            // 10. В одновимірному масиві визначити добуток елементів з парними номерами.
            int[] arr10 = FillArray("literal", 10);
            PrintArray(arr10);
            mul = 1;
            for (int i = 0; i < arr10.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    mul *= arr10[i];
                }
            }
            Console.WriteLine("Добуток: {0}\n", mul);
            
            // 11. Знайти суму елементів, розташованих між найбільшим та найменшим елементами.
            int[] arr11 = FillArray("keyboard", 3);
            Console.WriteLine("Сума: {0}\n", arr11[1]);
            
            // 12. Обчислити середнє арифметичне всіх елементів масиву К(12) цілих чисел,
            // які є від’ємні і мають парні номери.
            int[] arr12 = FillArray("random", -12);
            PrintArray(arr12);
            int avg = 0;
            int count = 0;
            for (int i = 0; i < arr12.Length; ++i)
            {
                if (arr12[i] < 0 && i % 2 == 0)
                {
                    avg += arr12[i];
                    ++count;
                }
            }
            if (count != 0)
            {
                avg /= count;
            }
            Console.WriteLine("Середнє арифметичне: {0}\n", avg);
            
            // 13. Обчислити суму та кількість елементів масиву Х(12) цілих чисел, більших за 1 і менших за 5.
            int[] arr13 = FillArray("random", 12);
            PrintArray(arr13);
            count = 0;
            sum = 0;
            foreach (int i in arr13)
            {
                if (i > 1 && i < 5)
                {
                    sum += i;
                    ++count;
                }
            }
            Console.WriteLine("Сума: {0}, кількість: {1}\n", sum, count);
            
            // 14. Обчислити суму номерів елементів масиву Х(12), менших за середнє арифметичне елементів цього масиву.
            int[] arr14 = FillArray("random", 12);
            PrintArray(arr14);
            sum = 0;
            for (int i = 0; i < arr14.Length; ++i)
            {
                if (arr14[i] < arr14.Average())
                {
                    sum += i;
                }
            }
            Console.WriteLine("Суму номерів елементів: {0}\n", sum);
            
            // 15. Обчислити різницю між найбільшим та найменшим елементами масиву Х(12) цілих чисел.
            int[] arr15 = FillArray("random", 12);
            PrintArray(arr15);
            int maxMinusMin = arr15.Max() - arr15.Min();
            Console.WriteLine("Різниця між найбільшим та найменшим елементом: {0}\n", maxMinusMin);
            
            // 16. Задано масив Х(12) цілих чисел. Перетворити заданий масив у наступний спосіб:
            // До всіх відємних елементів додати найбільший елемент масиву;
            // Всі нульові елементи замінити на 1;
            // Всі додатні елементи поділити на 2.
            int[] arr16 = FillArray("random", 12);
            PrintArray(arr16);
            for (int i = 0; i < arr16.Length; ++i)
            {
                if (arr16[i] < 0)
                {
                    arr16[i] += arr16.Max();
                }
                else if (arr16[i] == 0)
                {
                    arr16[i] = 1;
                }
                else if (arr16[i] > 0)
                {
                    // integer division!
                    arr16[i] /= 2;
                }
            }
            PrintArray(arr16);
        }
    }
}
