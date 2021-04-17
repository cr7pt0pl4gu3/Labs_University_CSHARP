using System;

namespace Lab_13
{
    internal class Product
    {
        private string _name;
        private DateTime _startDate;
        private double _price;
        private uint _quantity;

        public Product(string name, DateTime startDate, double price, uint quantity)
        {
            _name = name;
            _startDate = startDate;
            Price = price;
            Quantity = quantity;
        }

        public double Price
        {
            set
            {
                if (value > 250.0 || value < 10.0)
                {
                    throw new ArgumentException("Price must be in range of 10.0-250.0!");
                }
                _price = value;
            }
        }
        
        public double Quantity
        {
            set
            {
                if ((uint)value > 100)
                {
                    throw new ArgumentException("Quantity must be in range of 0-100!");
                }
                _quantity = (uint)value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("\n...");
            Console.WriteLine($"Name of the product: {_name}");
            Console.WriteLine($"Date of release: {_startDate.ToShortDateString()}");
            Console.WriteLine($"Price: {_price}");
            Console.WriteLine($"Quantity: {_quantity}");
            Console.WriteLine("...\n");
        }
    }

    internal class TMoney
    {
        private double _sumUSD;
        private double _exchangeRate = 0.036;

        public TMoney(double sumUSD)
        {
            _sumUSD = sumUSD;
        }

        public double GetUAH(double value)
        {
            double usd = value * _exchangeRate;
            if (_sumUSD - usd < 0.0)
            {
                throw new ArgumentException("You do not have sufficient funds to withdraw!");
            }

            _sumUSD -= usd;
            return usd / _exchangeRate;
        }

        public void AddUAH(double value)
        {
            double usd = value * _exchangeRate;
            _sumUSD += usd;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Balance: {_sumUSD}$");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Product cheese = new Product("Cheese", DateTime.Now, 35.0, 5);
            cheese.PrintInfo();
            cheese.Price = 43.0;
            cheese.Quantity = 3;
            cheese.PrintInfo();

            TMoney wallet = new TMoney(10.3);
            wallet.GetUAH(3);
            wallet.CheckBalance();
            wallet.AddUAH(74.5);
            wallet.CheckBalance();
            
        }
    }
}
