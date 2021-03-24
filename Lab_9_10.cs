using System;

namespace Lab_9_10
{
  public class Building
  {
    private uint people;
    private double S;
    private uint floorCount;
    
    public Building(uint people, double S, uint floorCount)
    {
      if (S <= 0.0)
        throw new ArgumentException("S needs to be positive.");
      
      this.people = people;
      this.S = S;
      this.floorCount = floorCount;
    }

    public double CalculateSPerPerson()
    {
      return S / people;
    }
  }

  public class MenuTwo
  {
    private string name;
    private string date;
    private double price;
    private double volume;
    private string type;

    public MenuTwo()
    {
      Console.WriteLine("Введіть назву напою : ");
      name = Console.ReadLine();
      Console.WriteLine("Введіть дату виготовлення напою : ");
      date = Console.ReadLine();
      Console.WriteLine("Введіть ціну напою : ");
      price = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введіть об'єм напою : ");
      volume = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введіть вид напою (гарячий, холодний, з добавками) : ");
      type = Console.ReadLine();
    }

    public void DisplayInfo()
    {
      if (price > 100)
      {
        price /= 2;
      }

      Console.WriteLine("Інформація про напій :");
      Console.WriteLine("Назва напою : " + name);
      Console.WriteLine("Дата виготовлення напою : " + date);
      Console.WriteLine("Ціна напою : " + price);
      Console.WriteLine("Об'єм напою : " + volume);
      Console.WriteLine("Вид напою : " + type);

    }
  }
  
  public class BIKS
  {
    private string name;
    private int date;
    private string place;
    private string phone;
    private string hair;

    public BIKS()
    {
      Console.WriteLine("Введіть ПІБ студента: ");
      name = Console.ReadLine();
      Console.WriteLine("Введіть рік народження студента : ");
      date = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введіть місто народження студента : ");
      place = Console.ReadLine();
      Console.WriteLine("Введіть номер телефона студента : ");
      phone = Console.ReadLine();
      Console.WriteLine("Введіть колір волосся студента : ");
      hair = Console.ReadLine();
    }
    public void DisplayInfo()
    {
      Console.WriteLine("Інформація про студента :");
      Console.WriteLine("ПІБ : " + name);
      Console.WriteLine("Дата народження : " + date);
      Console.WriteLine("Місце народження : " + place);
      Console.WriteLine("Номер телефона : " + phone);
      Console.WriteLine("Колір волосся : " + hair);
    }
    public void ReturnIf()
    {
      if (date > 1996)
        DisplayInfo();
      else
        Console.WriteLine("Студент {0} не входить в вікову категорію.", name);
    }
  }
  public class MenuOne
  {
    private string name;
    private string category;
    private double price;
    private double mass;
    private string type;

    public MenuOne(string name, string category, double price, double mass, string type)
    {
      this.name = name;
      this.category = category;
      this.price = price;
      this.mass = mass;
      this.type = type;
    }
    public void DisplayInfo()
    {
      Console.WriteLine("Інформація про страву:");
      Console.WriteLine("Назва продукту: " + name);
      Console.WriteLine("Категорія продукту: " + category);
      Console.WriteLine("Ціна продукту: " + price);
      Console.WriteLine("Вага продукту: " + mass);
      Console.WriteLine("Вид продукту: " + type);
    }
    public void ReturnIf()
    {
      if (price >= 78 && price <= 100)
        DisplayInfo();
      else
        Console.WriteLine("Страва {0} не входить в цінову категорію.", name);
    }
  }

  
  internal class Program
  {
    private static void ReverseArr(int[] arr, int value)
    {
      for (uint i = 0; i < arr.Length; ++i)
        if (arr[i] == value)
          arr[i] = arr[i] * -1;
    }
    
    private static void PrintArray(int[] arr)
    {
      Console.Write("[");
      for (int i = 0; i < arr.Length; ++i)
      {
        Console.Write(i == arr.Length - 1 ? "{0}" : "{0}, ", arr[i]);
      }
      Console.Write("]\n");
    }

    private static double MinThree(double a, double b, double c)
    {
      if ((a < b) && (a < c))
        return a;
      if ((b < a) && (b < c))
        return b;
      return c;
    }

    public static int Fibonacci(int element)
    {
      int a = 0;
      int b = 1;

      for (int i = 0; i < element; ++i)
      {
        int temp = a;
        a = b;
        b = temp + b;
      }
      return a;
    }
    
    public static void Main()
    {
      // Переключаю кодировку stdout (консоли) на UTF8 для поддержки русского и украинского языка
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      
      // Завдання 1.
      // Напишіть функцію, яка буде змінювати в масиві цілих чисел всі елементи,
      // які дорівнюють вказаним значенням (аргумент) на протилежне значення за знаком.
      // Наприклад, всі елементи масиву які дорівнюють 5, будуть змінюватися на -5.
      int[] array = {1, 3, 5, 7, 6, 2, 5, 0};
      ReverseArr(array, 5);
      PrintArray(array);
      
      // Завдання 2. Напишіть функцію, яка буде знаходити мінімальне число з трьох.
      Console.WriteLine("Min: {0}", MinThree(1, 5.2, 0));
      
      // Завдання 3.Напишіть функцію, яка буде повертати вказаний елемент ряду Фібоначчі.
      // Ряд Фібоначчі - це ряд, в якому кожен наступний елемент дорівнює сумі двох попередніх.
      // 1 1 2 3 5 8 13 21 ... Функція приймає порядковий номер елемента, і повертає відповідний елемент.
      Console.WriteLine("$4-Fibonacci = {0}", Fibonacci(4));
      
      // Завдання 4. Побудува програму яка містіть клас будинки, з полями: люди, площа, к-ть . поверхів.
      // Для одного будинку порахувати к-ть площі на одну особу. 
      Building building = new Building(7, 235.4, 3);
      Console.WriteLine("S / P = {0}", building.CalculateSPerPerson());
      
      // Завдання 5. Створити базовий клас Меню, що має поля Назва страви, категорія, ціна, вага, вид страви.
      // Клас має об’єкти: торти і кекси (2 об’єкта). Створіть метод, який вносить дані по стравам з клавіатури.
      // Створіть метод, який виводить дані. Метод, що виводить страву ціна, якої від 78-100 грн.
      // Дані записати у файли.
      MenuOne tort = new MenuOne("Торт", "Выпечка", 78.0, 22.0, "Выпечка");
      tort.DisplayInfo();
      MenuOne keks = new MenuOne("Кекс", "Выпечка", 12.0, 3.0, "Выпечка");
      keks.ReturnIf();
      
      // Завдання 6. Створити клас Меню,
      // що має поля Назва напою, дата виготовлення, ціна, об’єм,
      // вид напою (гарячий, холодний, з добавками).
      // Клас має об’єкти: чай і кава (2 об’єкта)
      // Створіть метод, який вносить дані по напоям з клавіатури.
      // Створіть метод, який виводить дані. Метод, що виводить напій і, якщо його ціна більше 100 грн.,
      // то на нього знижка 50%.
      MenuTwo tea = new MenuTwo();
      tea.DisplayInfo();
      
      // Завдання 7. Створити клас «БІКС», що має наступні дані про студентів:
      // ПІБ, Дата народження, Місто народження, Номер телефону, Колір волосся.
      // Клас «БІКС» містить інформацію про 3 хлопців.
      // Написати метод, який автоматично вводить дані, та метод, який виводить дані.
      // Метод, що виводить дані про хлопців дата народження яких після 1996 року
      BIKS one = new BIKS();
      one.DisplayInfo();
      BIKS two = new BIKS();
      two.ReturnIf();
      BIKS three = new BIKS();
      three.DisplayInfo();
      Console.ReadLine();
    }
  }
}
