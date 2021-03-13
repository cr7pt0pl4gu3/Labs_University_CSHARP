using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_7
{
    internal class Program
    {
        public static void Main()
        {
            // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
            Console.OutputEncoding = Encoding.UTF8;
            
            // 1. Створіть файл group.txt і запишіть в нього натуральні числа від 1 до 523 через кому.
            string writeString = "";
            for (uint i = 1; i <= 523; ++i)
            {
                if (i == 523)
                    writeString += i;
                else
                    writeString += i + ", ";
            }
            File.WriteAllText("group.txt", writeString);
            
            // 2. Дано масив рядків: "Кобзар", "Марія", "Заповіт", "Словник", "Інформатика".
            // Запишіть в файл елементи масива порядково (кожен елемент в новому рядку).
            writeString = "";
            string[] array = {"Кобзар", "Марія", "Заповіт", "Словник", "Інформатика"};
            foreach (var str in array)
            {
                writeString += str + "\n";
            }
            File.WriteAllText("array.txt", writeString);
            
            // 3. Візьміть будь-який текстовий файл, і найдіть в ньому розмір самому довший рядок.
            string readText = File.ReadAllText("array.txt");
            string biggestLine = "";
            using (StringReader reader = new StringReader(readText))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length > biggestLine.Length)
                        biggestLine = line;
                }
            }
            Console.WriteLine(biggestLine);
            
            /*
            4. Створити текстовий файл, у який записати масив число від 10 до 100. 
            Масив згенерувати довільними цілими числами, що менші 55.
            Візьміть цей текстовий файл, і найдіть в ньому:
            - найбільший і наймений елементи;
            - суму всіх елементів;
            - середнє арифметичне значень масиву.
            */
            int[] intArr = new int[100];
            Random rand = new Random();
            for (uint i = 0; i < intArr.Length; ++i)
            {
                intArr[i] = rand.Next(1, 55);
            }
            string intArrStr = String.Join(" ", intArr);
            File.WriteAllText("array2.txt", intArrStr);
            readText = File.ReadAllText("array2.txt");
            int[] fileArr = Array.ConvertAll(readText.Split(' '), int.Parse);
            int max = fileArr.Max();
            int min = fileArr.Min();
            int sum = fileArr.Sum();
            int mean = fileArr.Sum() / fileArr.Length;
            Console.WriteLine("MAX = {0}, MIN = {1}, SUM = {2}, MEAN = {3}", max, min, sum, mean);
            Console.ReadLine();
        }
    }
}
