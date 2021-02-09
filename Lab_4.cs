using System;
namespace Lab
{
    internal class Program
    {
        public static void Main()
        {
            // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // 1. Піднесіть до степеня всі натуральні числа в діапазоні від 3-115.
            for (int i = 3; i <= 115; ++i)
            {
                Console.Write("{0} ", Math.Pow(i, 2));
            }
            
            Console.WriteLine("\n");
            
            // 2. Піднесіть до степеня всі парні числа в діапазоні від 0-110.
            for (int i = 2; i <= 110; i += 2)
            {
                Console.Write("{0} ", Math.Pow(i, 2));
            }
            
            /*
             3. Дано два цілих числа A і B (A < B).
             Знайти всі цілі числа, розташовані між даними числами (включаючи самі ці числа),
             в порядку їх зростання, а також кількість N цих чисел.
            */
            Console.Write("\n\nВведите число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int N = 0;
            while (A <= B)
            {
                Console.Write("{0} ", A);
                ++A;
                ++N;
            }
            Console.Write("\nКоличество N: {0}", N);
            
            /*
             4. Дано два цілих числа A і B (A < B).
             Знайти всі цілі числа, розташовані між даними числами (не включаючи самі ці числа),
             в порядку їх зменшення, а також кількість N цих чисел.
            */
            Console.Write("\n\nВведите число А: "); 
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            B = Convert.ToInt32(Console.ReadLine());
            N = 0;
            while (B >= A)
            {
                Console.Write("{0} ", B);
                --B;
                ++N;
            }
            Console.WriteLine("\nКоличество N: {0}\n", N);
            
            // 5. За допомогою циклу вивести на екран в один рядок всі тризначні числа, які кратні 3 і 7.
            for (int i = 100; i < 1000; ++i)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                    Console.Write("{0} ", i);
                }
            }
            
            Console.WriteLine("\n");
            
            // 6. За допомогою циклу вивести на екран в один стовпчик  всі двозначні числа, які кратні які діляться на 15.
            for (int i = 10; i < 100; ++i)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            // 7. За допомогою циклу з лічильником знайти похідні цілих чисел від 2 до 16
            // Производная константы равна нулю? ???
            
            /*
             Дано дійсне число A (> 1).
             Вивести найменше із цілих чисел N, для яких сума 1 + 1/2 + ··· + 1 / N буде більше A,
             і вивести  саму суму
            */
            Console.Write("\n\nВведите число А (> 1): "); 
            A = Convert.ToInt32(Console.ReadLine());
            N = Int32.MaxValue;
            double sum = 0;
            for (int i = 1; i < N; ++i)
            {
                sum += 1.0 / i;
                if (sum > A)
                {
                    N = i;
                    break;
                }
            }
            
            Console.WriteLine("N: {0}, сумма: {1}", N, sum);
            
            // Задача №4. Скласти програму для знаходження суми всіх натуральних чисел на проміжку від A до B включно
            Console.Write("\n\nВведите число А: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            B = Convert.ToInt32(Console.ReadLine());
            int int_sum = 0;
            while (A <= B)
            {
                int_sum += A;
                ++A;
            }
            Console.Write("\nСумма: {0}", int_sum);
            Console.ReadLine();
        }
    }
}
