using System;
namespace Lab_2
{
    internal class Program
    {
        public static void Main()
        {
            // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            double a = 3.0;
            double b = -1.0;
            double c = -2.0;

            double[] xArr = CalculateQuadraticEquation(a, b, c);
            Console.WriteLine("1. Корни квадратного уравнения 3х^2-х-2=0:\nx1 = {0}, x2 = {1}", xArr[0], xArr[1]);

            double x = 1.573;
            a = 1.775;
            double result = EvaluateExpression(x, a);
            Console.WriteLine("2. Решение примера №18: {0}", result);
        }

        private static double EvaluateExpression(double x, double a)
        {
            double partOne = Math.Log(1.0 + Math.Sqrt(1.0 + Math.Pow(x, 2.0)));
            double partTwo = (1.0 + Math.Pow(x, 2.0)) / Math.Pow(1.0 + (Math.Pow(a, 3) / 2), 1.0 / 3);
            double result = partOne + partTwo;
            return result;
        }
        private static double[] CalculateQuadraticEquation(double a, double b, double c)
        {
            double d = Math.Pow(b, 2.0) - (4.0 * a * c);
            if (d < 0)
            {
                // Уравнение не имеет корней
                double[] xArr = {0.0, 0.0};
                return xArr;
            }
            else if (d == 0)
            {
                // Уравнение имеет 1 корень
                double x = -b / (2.0 * a);
                double[] xArr = {x, x};
                return xArr;
            }
            else
            {
                // Уравнение имет 2 корня
                double x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                double[] xArr = {x1, x2};
                return xArr;
            }
        }
    }
}
