using System;
using System.IO;

namespace Lab_12
{
    internal class Soldier
    {
        private string _name;
        private DateTime _start;
        private DateTime _finish;
        private string _location;
        
        public Soldier(string name, DateTime start, DateTime finish, string location)
        {
            _name = name;
            _start = start;
            _finish = finish;
            _location = location;
        }

        public void PrintSoldier()
        {
            Console.WriteLine($"Soldier name: {_name}");
            Console.WriteLine($"Start date: {_start.ToShortDateString()}");
            Console.WriteLine($"End date: {_finish.ToShortDateString()}");
            Console.WriteLine($"Location: {_location}");
            string write = "Soldier name: " + _name + "\n" +
                           "Start date: " + _start.ToShortDateString() + "\n" +
                           "End date: " + _finish.ToShortDateString() + "\n" +
                           "Location: " + _location + "\n";
            File.WriteAllText("output.txt", write);
        }
    }

    internal class Car
    {
        private string _name;
        private double _price;
        private DateTime _startYear;
        private string _color;
        private string _type;

        public Car(string name, double price, DateTime startYear, string color, string type)
        {
            _name = name;
            _price = price;
            _startYear = startYear;
            _color = color;
            _type = type;
        }

        public void PrintIfOld()
        {
            if (DateTime.Now.Year - _startYear.Year > 1)
                PrintCar();
        }

        public void PrintCar()
        {
            Console.WriteLine($"Car model: {_name}");
            Console.WriteLine($"Car price: {_price}$");
            Console.WriteLine($"Car year: {_startYear.Year}");
            Console.WriteLine($"Car color: {_color}");
            Console.WriteLine($"Car type: {_type}");
        }
    }
    
    internal class Program
    {
        public static void Main()
        {
            try
            {
                int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                int x, y;
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                int result = arr[x] + arr[y];
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Caught an exception!");
            }
            
            Console.WriteLine();
            
            try
            {
                Soldier soldier = new Soldier("Alex Shadow", new DateTime(2000, 11, 11),
                    new DateTime(2002, 12, 12), "Ukraine");
                soldier.PrintSoldier();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught an exception!");
            }
            
            Console.WriteLine();
            
            try
            {
                Car forza = new Car("Forza X11", 30000000,
                    new DateTime(2017, 12, 12), "red", "sport car");
                forza.PrintCar();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught an exception!");
            }
        }
    }
}
