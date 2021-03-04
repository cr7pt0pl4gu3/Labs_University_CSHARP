using System;
using System.IO;
using System.Text;

namespace Lab_6
{
    internal class Program
    {
        public static void Main()
        {
            // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
            Console.OutputEncoding = Encoding.UTF8;

            // 1.Ввести три імені. Серед даних імен вибрати ті, що починаються з букви «В» і вивести їх
            string a, b, c;
            Console.WriteLine("Введите три имя:\n");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            Console.WriteLine("\nНачинаются на 'В':");
            if (a[0] == 'В')
                Console.WriteLine("{0}", a);
            if (b[0] == 'В')
                Console.WriteLine("{0}", b);
            if (c[0] == 'В')
                Console.WriteLine("{0}", c);
            /*
             2. Дано текст: 
            «Нiчого не буває просто так,
            Нiчого не буває випадково:
            Нi зустрiч, нi подiя, анi слово...
            До того йшло, або ж це Долi Знак».
            - необхідно замінити в тексті слово «Нiчого не» на «Все».
            - порівняти рядки і вивести на екран, який найдовший.
            - вивести на екран рядок без останніх двох слів. 
            */
            string text =
                "Нiчого не буває просто так,\nНiчого не буває випадково:\nНi зустрiч, нi подiя, анi слово...\nДо того йшло, або ж це Долi Знак";
            text = text.Replace("Нiчого не", "Все");
            Console.WriteLine("\nТекст:\n{0}", text);
            string biggestLine = "";
            using (StringReader reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    if (line.Length > biggestLine.Length)
                        biggestLine = line;
            }

            Console.WriteLine("\nСамая длинная строка:\n{0}", biggestLine);
            biggestLine = biggestLine.Replace("анi слово", "");
            Console.WriteLine("\nСтрока без последних двух слов:\n{0}", biggestLine);

            /*
            3. Дано текст 
            Я хочу, щоб у морі сліз,
            У СВІТІ, ДЕ ПАНУЄ ЛИХО,
            ПОЕЗІЇ РОСТОЧОК РІС:
            Втішав, нагадував і кликав.
            - необхідно привести  текст до одного формату.
            */

            text = @"Я хочу, щоб у морі сліз,
У СВІТІ, ДЕ ПАНУЄ ЛИХО,
ПОЕЗІЇ РОСТОЧОК РІС:
Втішав, нагадував і кликав.";
            text = text.ToUpper();
            Console.WriteLine("\nТекст:\n{0}\n", text);

            /*
             4. Дано рядок, який містить імена користувачів, розділені комою - "Login1, LOgin2, login3, loGin4".
             Необхідно розбити цей рядок на масив рядків (щоб окремо були логіни), і перевести їх всіх в нижній регістр.
            */
            string names = "Login1, LOgin2, login3, loGin4";
            names = names.ToLower();
            string[] words = names.Split(' ');
            foreach (string word in words)
            {
                Console.Write("{0} ", word);
            }
        }
    }
}
