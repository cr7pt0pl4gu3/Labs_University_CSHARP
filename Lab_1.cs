namespace Lab_1
{
    internal class Program
    {
        public static void Main()
        {
            /*
             1.З якого методу починається виконання С#-програми?
             public static void Main()
             
             2.Які дії виконує метод Console.WriteLine ();?
             Выводит данные в stdout (в данном случае - консоль), и применяет символ новой строки \n
             
             3.Як називається програма компілятор, що запускається з командної строки?
             Microsoft (R) Build Engine
             
             4.Яке ключове слово в С# використовується для цілого типу даних?
             int
             
             5.Що означає термін double?
             Число с плавающей точкой
             
             6.Обовязково в C# програмі використовувати оператор Using System?
             Нет. System - пространство имён, в данном случае я могу написать System.Console.WriteLine();
             
             7.Як створити блок коду?
             Поставить открывающие и закрывающие фигурные скобки, между них - блок кода.
             
             8.Як завершаються оператори в С#?
             Символом ;
             
             9.Правдиво чи ні, що всі оператори повинні починатися і закінчуватися в одному рядку?
             Нет. Для окончания используют символ ;
             */
            
            // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            double c = 31.1111;
            double e = 2.718;

            System.Console.WriteLine("1. Вивести на дисплей число с точністю до сотих: {0:F2}", c);
            System.Console.WriteLine("2. Вивести на дисплей число e  с точностю до десятих: {0:F1}", e);
            System.Console.WriteLine("3. Вивести в одному рядку числа 1, 13 и 49 с одним пробілом між ними: {0} {1} {2}", 1, 13, 49);
            System.Console.WriteLine("4. Вивести на экран числа 50 и 10 одне під одним: \n{0}\n{1}", 50, 10);
            
            System.Console.WriteLine("5. Написати програму виведення  на дисплей наступної інформації:");
            int t, v, x, y;
            System.Console.Write("Введiть t -> ");
            t = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Введiть v -> ");
            v = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Введiть x -> ");
            x = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Введiть y -> ");
            y = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("а) 5 10  б   100 {0}  в) {1} 25", t, x);
            System.Console.WriteLine("   7 см  )   1949      {0} {1}", x, y);
            System.Console.WriteLine("             {0}", v);
            
            System.Console.WriteLine("6. Підприємство поклало в банк на депозитний рахунок суму в S тисяч гривень під 40 % річних Яку суму зніме підприємство в кінці року?");
            System.Console.Write("Введiть S -> ");
            double S = System.Convert.ToDouble(System.Console.ReadLine());
            double result = S + (S / 100 * 40);
            System.Console.WriteLine("Яку суму зніме підприємство в кінці року = {0} тисяч гривень.", result);
        }
    }
}
