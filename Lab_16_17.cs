using System;

namespace Lab_16_17
{
    internal class Program
    {
        private struct Circle
        {
            private double _r1;
            private double _r2;
            private double _r3;
            private double _rAvg;
            private double _final;

            public Circle(double r1, double r2, double r3)
            {
                _r1 = r1;
                _r2 = r2;
                _r3 = r3;
                _rAvg = (_r1 + _r2 + _r3) / 3.0;

                double diff1 = Math.Abs(_rAvg - _r1);
                double diff2 = Math.Abs(_rAvg - _r2);
                double diff3 = Math.Abs(_rAvg - _r3);

                if (diff1 <= diff2 && diff1 <= diff3)
                    _final = _r1;
                else if (diff2 <= diff1 && diff2 <= diff3)
                    _final = _r2;
                else
                    _final = _r3;

                Console.WriteLine(_final);
            }
        }

        struct Student
        {
            private string _fn;
            private string _ns;
            private uint _year;
            private uint[] _bal;

            public Student(string fn, string ns, uint year)
            {
                _fn = fn;
                _ns = ns;
                _year = year;
                _bal = new uint[4];
                Console.WriteLine("\nEnter student grades [4 lines]:");
                for (int i = 0; i < 4; ++i)
                {
                    _bal[i] = Convert.ToUInt32(Console.ReadLine());
                }

                if (year == 2001)
                    Console.WriteLine("\n" + fn + " was born in 2001");
            }
        }
        
        struct ProductStore
        {
            private uint _n;
            private string[,] _info;
            private uint _min;
            private string _minn;

            public ProductStore(uint n)
            {
                _n = n;
                _info = new string[_n, 4];
                for (int i = 0; i < _info.GetLength(0); i++)
                {
                    Console.WriteLine("\n-----\nName: ");
                    _info[i, 0] = Console.ReadLine();
                    Console.WriteLine("Type: ");
                    _info[i, 1] = Console.ReadLine();
                    Console.WriteLine("Quantity: ");
                    _info[i, 2] = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    _info[i, 3] = Console.ReadLine();
                }

                _min = Convert.ToUInt32(_info[0, 3]);
                _minn = _info[0, 0];
                for (int i = 1; i < _info.GetLength(0); i++)
                {
                    if (Convert.ToUInt32(_info[i,3]) < _min)
                    {
                        _min = Convert.ToUInt32(_info[i, 3]);
                        _minn = _info[i, 0];
                    }
                }
                Console.WriteLine("\n___________________________________\n\nThe least expensive product is {0}." +
                                  "\nIt costs {1}$", _minn, _min);

            }
        }
        
        struct Student2
        {
            private uint _n;
            private string[,] _inf;
            private uint _min;
            private string[] _marks;

            public Student2(uint n)
            {
                _n = n;
                _inf = new string[_n, 3];
                for (int i = 0; i < _inf.GetLength(0); ++i)
                {
                    Console.WriteLine("\n-----\nName: ");
                    _inf[i, 0] = Console.ReadLine();
                    Console.WriteLine("Year: ");
                    _inf[i, 1] = Console.ReadLine();
                    Console.WriteLine("Marks in format mark1, mark2, mark3, mark4: ");
                    _inf[i, 2] = Console.ReadLine();
                }

                _min = Convert.ToUInt32(_inf[0, 1]);
                for (int i = 0; i < _inf.GetLength(0); i++)
                {
                    if (Convert.ToUInt32(_inf[i, 1]) < _min)
                    {
                            _min = Convert.ToUInt32(_inf[i, 1]);
                    }
                }
                Console.WriteLine();
                for (int r = 0; ; r++)
                {
                    for (int i = 0; i < _inf.GetLength(0); i++)
                    {
                        if (Convert.ToUInt32(_inf[i, 1]) == _min)
                        {
                            Console.WriteLine($"{_inf[i, 0]}\t{_inf[i, 1]}\t{_inf[i,2]}");
                            _inf[i, 2].Replace(" ", "");
                            _marks = new string[4];
                            _marks = _inf[i, 2].Split(',');
                            uint sum = 0;
                            for (int c = 0; c < 4; c++)
                            {
                                    sum += Convert.ToUInt32(_marks[c]);
                            }
                            double average = sum / 4.0;
                            if (average > 4.0)
                            {
                                Console.WriteLine("Average mark of {0} is higher than 4.0", _inf[i,0]);
                            }
                        }
                    }
                    ++_min;
                }
            }
        }
        
        public static void Main()
        {
            // Створіть програму, яка буде знаходити окружність (структура)
            // у якої радіус максимально близький до середнього значення радіусів кіл зі списку.
            Circle circle = new Circle(1.0, 7.0, 33.0);
            
            /*2. Створити структуру STUDENT, яка містить  наступні поля:
                • Name  – Прізвище та ініціали;
                • Year – рік народження:
                • Bal – оцінки з 4 предметів (масив з 4 елементів)

                2. Написати програму, що використовує дану структуру і виконує наступні дії:
                • вводить з клавіатури масив даних Group, що складається з N змінних типу STUDENT;
                • Виводить на екран прізвища і рік народження 2001 студентів;
            */
            Student gareth = new Student("Gareth", "S.G.", 2003); 
            Student jesus = new Student("Jesus", "J.J.", 2001); 
            Student vardy = new Student("Vardy", "V.V.", 2002);
            
            //3.Створити структура магазин, яка містить  наступні поля:
            //-	Name  – Назва товару;
            //-	Type – одиниця вимірювання:
            //-	Quantity – кількість одиниць товару;
            //-	Cost – ціна одиниці товару.
            //Написати програму, що використовує дану структуру і виконує наступні дії:
            //-	вводить з клавіатури масив даних Tovar, що складається з N змінних типу Shop;
            //-	Виводить на екран товар з найменшою ціною.
            ProductStore a = new ProductStore(4);
            
            //4.	Описати структуру з ім‘ям  STUDENT, яка містить  наступні поля:
            //-	- Name  – Прізвище та ініціали;
            //-	 - Year – рік народження:
            //-	- Bal – оцінки з 4 предметів(масив з 4 елементів)
            //Написати програму, що використовує дану структуру і виконує наступні дії:
            //-	 - вводить з клавіатури масив даних Group, що складається з N змінних типу STUDENT;
            //-	 - Впорядковує записи за зростанням поля Year
            //-	 - Виводить на екран прізвища і рік народження студентів середній бал яких > 4.0; 
            Student2 student2 = new Student2(1);
        }
    }
}
