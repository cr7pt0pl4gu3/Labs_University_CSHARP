using System;
namespace Lab_3
{
    internal class Program
    {
        public static void Main()
        {
            // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            /*
             С клавиатури вводятся два числа – к-ть забитих голів хозяйнами и гостями в футбольному матчі.
             Вивести на екран результат гри – перемогли свої/гості/нічія.
             */
            Console.Write("Введите количество голов домашней команды -> ");
            int homeTeam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество голов гостевой команды -> ");
            int awayTeam = Convert.ToInt32(Console.ReadLine());
            IdentifyWinner(homeTeam, awayTeam);
            
            /*
             Напишіть програму, яка буде преревіряти число на кратність 3-м і 7-м (це числа 21, 42, 63…).
             Вивести на екран відповідне повідомлення.
             */
            Console.Write("Введите число кратное тройке и семерке -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            CheckNumber(n);
            
            /*
             Написати логічний вираз, який є істинним коли парне число А не ділиться на 3,
             але ділиться на 4, якщо воно ділиться на 7- то не ділиться на 4,
             якщо воно ділиться на 2 – то ділиться на 14.
             */
            Console.Write("Введите число А -> ");
            int a = Convert.ToInt32(Console.ReadLine());
            // Логическое выражение - тернарный оператор? Могу сделать if/else, но если надо тернарный, вот:
            bool expressionResult =
                (((a % 2 == 0) && (a % 3 != 0) && (a % 4 == 0)) || ((a % 7 == 0) && (a % 4 != 0)) ||
                 ((a % 2 == 0) && (a % 14 == 0)))
                    ? true
                    : false;
            Console.WriteLine("Результат логического выражения: {0}", expressionResult);
            
            /*
             Побудувати програму: З 4 травня 2018 року  пройшло m (від 1 до 31 ) днів місяця,
             визначити поточний день місяця. ??? Не совсем понял задание, сделаю немного по другому:
             */
            DateTime old = new DateTime(2018, 5, 4);
            TimeSpan result = DateTime.Today.Subtract(old);
            Console.WriteLine("З 4 травня 2018 року пройшло {0} днів.", result.Days);
            
            /*
             Написати логічний вираз, для розрахунку суми виплат по депозиту на вкад в різних валютах:
                -До 2000 грн – нараховується 10% річних;
                -До 2000 евро – нараховується 11% річних;
                -До 2000 дол. – нараховується 15% річних;
             Кінцевий результат, також конвертувати в грн. Визначити в якій валюті буде вигідний вклад.
             */

            CalculateDeposit();
        }

        private static void CalculateDeposit()
        {
            // Курсы валют
            double usdToUah = 28.00;
            double eurtoUah = 33.66;

            /*
             В данном случае я не проверяю пользователя на адекватность,
             но рассчитываю что он введет положенные данные (это ведь калькулятор, а не банк ;))
             */
            Console.WriteLine("Выгодные вклады в долларах (15%)!\nЕвро (11%)!\nГривна (10%)!");
            Console.WriteLine("1 - гривна, 2 - евро, 3 - доллар.");
            Console.WriteLine("Введите цифру валюты, в которой вы хотите сделать депозит -> ");
            short sign = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите сумму (максимум 2000) -> ");
            double deposit = Convert.ToDouble(Console.ReadLine());

            if (deposit > 2000)
            {
                Console.WriteLine("Вы ввели неправильную сумму!");
                return;
            }
            
            if (sign == 1)
            {
                deposit += deposit / 100 * 10;
            }
            else if (sign == 2)
            {
                deposit += deposit / 100 * 11;
                deposit *= eurtoUah;
            }
            else if (sign == 3)
            {
                deposit += deposit / 100 * 15;
                deposit *= usdToUah;
            }
            else
            {
                Console.WriteLine("Вы ввели неправильную цифру валюты!");
                return;
            }
            
            Console.WriteLine("Ваш конечный баланс = {0} грн.", deposit);
        }
        
        private static void CheckNumber(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Число кратне 3-м і 7-м.");
            }
            else
            {
                Console.WriteLine("Число не кратне 3-м і 7-м.");
            }
        }
        
        private static void IdentifyWinner(int homeTeam, int awayTeam)
        {
            if (homeTeam > awayTeam)
            {
                Console.WriteLine("Победила команда хозяев, со счетом {0}:{1}", homeTeam, awayTeam);
            }
            else if (awayTeam > homeTeam)
            {
                Console.WriteLine("Победила команда гостей, со счетом {0}:{1}", awayTeam, homeTeam);
            }
            else
            {
                Console.WriteLine("Ничья, со счетом {0}:{1}", awayTeam, homeTeam);
            }
        }
    }
}
