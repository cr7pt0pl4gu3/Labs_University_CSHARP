using System;

namespace Lab_8
{
    internal class Program
    {
        public static void Main()
        {
            // 1. Побудувати масив 6x6. Заповнення массиву з клавіатури. Знайти суму елементів массиву кратну 3.
            int[,] arr = new int[6, 6];
            int sum = 0;
            for (uint i = 0; i < arr.GetLength(0); ++i)
            {
                for (uint j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write("> ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i, j] % 3 == 0)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine("Sum: {0}", sum);
            
            // 2. Побудувати масив 2x4.
            // Оголошення масиву з одночасним заданням. Знайти суму елементів тільки 2-го та 4-го стовпців значень.
            sum = 0;
            int[,] arr2 = {{1, 2, 3, 4}, {5, 6, 7, 8}};
            for (uint i = 0; i < arr2.GetLength(0); ++i)
            {
                for (uint j = 0; j < arr2.GetLength(1); ++j)
                {
                    if (j == 2 || j == 4)
                        sum += arr2[i, j];
                }
            }
            Console.WriteLine("Sum: {0}", sum);
            
            // 3. Знайти середнє арифметичне значення елементів масиву А[1..9].
            // Обчислити добуток додатних елементів.
            // А[1..9] - не двовимiрний масив.
            
            // 4. Дано квадратну матрицю розмірності n. Надрукувати суму елементів бічної діагоналі.
            int[,] arr3 = { {1, -2}, {-3, 4} };
            sum = 0;
            sum += arr3[0, 1];
            sum += arr3[1, 0];
            Console.WriteLine("Sum: {0}", sum);
            // 5. Визначити мінімальний елемент кожного рядка матриці.
            // Надрукувати його значення та індекси.
            // Знайти добуток додатнiх елементів квадратної матриці, які розміщені на її головній діагоналі.
            for (uint i = 0; i < arr3.GetLength(0); ++i)
            {
                int min = arr3[i, 0];
                uint index1 = i;
                uint index2 = 0;
                for (uint j = 0; j < arr3.GetLength(1); ++j)
                {
                    if (arr3[i, j] < min)
                    {
                        min = arr3[i, j];
                        index1 = i;
                        index2 = j;
                    }
                }
                Console.WriteLine("Minimal: {0}, [{1}, {2}];", min, index1, index2);
            }
            int mul = 1;
            if (arr3[1, 0] >= 0) 
                mul *= arr3[1, 0];
            if (arr3[0, 1] >= 0)
                mul *= arr3[0, 1];
            if (arr3[0, 1] < 0 || arr3[1, 0] < 0)
                mul = 0;
            Console.WriteLine("Mul: {0}", mul);
            
            // 6. Для кожного рядка матриці надрукувати номери стовпців, що містять додатні елементи.
            // Знайти добуток від’ємних елементів квадратної матриці, які розміщені на її головній діагоналі.
            
            for (uint j = 0; j < arr3.GetLength(1); ++j)
            {
                bool flag = false;
                for (uint i = 0; i < arr3.GetLength(0); ++i)
                {
                    if (arr3[i, j] >= 0)
                        flag = true;
                }
                if (flag)
                    Console.WriteLine("j:{0}", j);
            }
            
            mul = 1;
            if (arr3[1, 0] <= 0) 
                mul *= arr3[1, 0];
            if (arr3[0, 1] <= 0)
                mul *= arr3[0, 1];
            if (arr3[0, 1] > 0 || arr3[1, 0] > 0)
                mul = 0;
            Console.WriteLine("Mul: {0}", mul);
            
            // 7. Визначити і надрукувати кількість від’ємних елементів у кожному стовпці матриці.
            // Визначити і надрукувати найменший елемент матриці та його індекси.
            for (uint j = 0; j < arr3.GetLength(1); ++j)
            {
                int counter = 0;
                for (uint i = 0; i < arr3.GetLength(0); ++i)
                {
                    if (arr3[i, j] < 0)
                        ++counter;
                }
                Console.WriteLine("Count: {0}", counter);
            }
            int minimal = arr3[0, 0];
            uint i1 = 0;
            uint i2 = 0;
            for (uint j = 0; j < arr3.GetLength(1); ++j)
            {
                
                for (uint i = 0; i < arr3.GetLength(0); ++i)
                {
                    if (arr3[i, j] < minimal)
                    {
                        minimal = arr3[i, j];
                        i1 = i;
                        i2 = j;
                    }
                }
            }
            Console.WriteLine("Min: {0}, [{1}, {2}]", minimal, i1, i2);
            Console.ReadLine();
        }
    }
}
