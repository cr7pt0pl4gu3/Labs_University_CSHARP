using System;

namespace Task
{
    class Program
    {
        class PathFinder
        {
            private uint _id;
            private string _destination;
            public DateTime _start;
            public DateTime _end;
            public double _exchange;

            public PathFinder(uint id, string destination, DateTime start, DateTime end, double exchange)
            {
                _id = id;
                _destination = destination;
                _start = start;
                _end = end;
                _exchange = exchange;
            }

            public void PrintInfo()
            {
                Console.WriteLine();
                Console.WriteLine("######################################");
                Console.WriteLine($"Path id: {_id}");
                Console.WriteLine($"Path destination {_destination}");
                Console.WriteLine($"Department time: {_start}");
                Console.WriteLine($"Arrival time: {_end}");
                Console.WriteLine($"Road time: {_end - _start}");
                Console.WriteLine($"Post exchange time: {_exchange}");
                Console.WriteLine("######################################");
                Console.WriteLine();
            }
        }

        static void CheckPath(PathFinder path)
        {
            int year, month, day;
            Console.Write("Enter start year -> ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter start month -> ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter start day -> ");
            day = Convert.ToInt32(Console.ReadLine());
            DateTime start = new DateTime(year, month, day);
            
            Console.Write("Enter end year -> ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end month -> ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end day -> ");
            day = Convert.ToInt32(Console.ReadLine());
            DateTime end = new DateTime(year, month, day);

            if (path._start >= start && path._end <= end && path._exchange <= 20)
            {
                path.PrintInfo();
            }
        }
        
        static void Main()
        {
            /*
             * Завдання 23.  Написати програму: Маршрут руху поштових машин:
             * № маршруту; пункт призначення;  час виїзду на маршрут;
             * час прибуття в призначений пункт; тривалість часу обміну пошти в хвилинах.
             * Написати метод, щоб вивести інформацію по всіх маршрутах
             * із зазначенням витраченого часу на шлях (в хвилинах);
             * ввести два значення часу;
             * вивести інформацію про маршрути, виїзд яких планується в зазначений інтервал часу
             * і тривалість часу обміну пошти не перевищує 20 хвилин.
             */
            PathFinder myPath = new PathFinder(0, "Kiev City", new DateTime(2020, 3, 1), DateTime.Today, 19);
            CheckPath(myPath);
        }
    }
}
