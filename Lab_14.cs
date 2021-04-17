using System;

namespace Lab_14
{
    internal class CoffeeMachine
    {
        private enum CoffeeType
        {
            Cappuccino = 30,
            Espresso = 100,
            Mocha = 50
        }

        public void DrinkSomething()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);
            switch (choice)
            {
                case 1:
                    DrinkSpecific(CoffeeType.Cappuccino.ToString(), (int)CoffeeType.Cappuccino);
                    break;
                case 2:
                    DrinkSpecific(CoffeeType.Espresso.ToString(), (int)CoffeeType.Espresso);
                    break;
                case 3:
                    DrinkSpecific(CoffeeType.Mocha.ToString(), (int)CoffeeType.Mocha);
                    break;
            }
        }

        private void DrinkSpecific(string name, int percentage)
        {
            Console.WriteLine("...");
            Console.WriteLine($"Drinking {name}!");
            Console.WriteLine($"Coffee percentage is {percentage}%!");
        }
    }
    
    internal class Program
    {
        enum Food
        {
            Borscht = 224,
            Potato = 77,
            PigMeat = 242,
            Vegetables = 65,
            Fruits = 50,
            Tea = 1,
            Coffee = 0
        }
        
        public static void Main()
        {
            foreach (Food food in Enum.GetValues(typeof(Food)))
            {
                int calories = (int)food;
                Console.WriteLine($"{food} has {calories} calories.");
            }

            Console.WriteLine();
            
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.DrinkSomething();
            coffeeMachine.DrinkSomething();
            coffeeMachine.DrinkSomething();
            coffeeMachine.DrinkSomething();
        }
    }
}
