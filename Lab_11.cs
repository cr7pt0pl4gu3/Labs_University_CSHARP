using System;

namespace Lab_11
{
  internal class Student
  {
    private string _name;
    private DateTime _birth;
    private int[] _bal;

    public Student(string name, DateTime birth, int[] bal)
    {
      _name = name;
      _birth = birth;
      _bal = bal;
    }

    public bool IsYoung()
    {
      if (_birth.Year > 2002)
      {
        return true;
      }
      return false;
    }

    public void PrintInfo()
    {
      Console.WriteLine("###############################################################");
      Console.WriteLine($"Student name: {_name}");
      Console.WriteLine($"Student birthday: {_birth.ToShortDateString()}");
      Console.WriteLine($"Student grades: chemistry = {_bal[0]}, " +
                        $"PE = {_bal[1]}, science = {_bal[2]}, biology = {_bal[3]}");
      Console.WriteLine("###############################################################");
    }
  }

  internal class Product
  {
    private string _name;
    private string _type;
    private uint _quantity;
    private uint _cost;

    public Product(string name, string type, uint quantity, uint cost)
    {
      _name = name;
      _type = type;
      _quantity = quantity;
      _cost = cost;
    }
    
    public void PrintInfo()
    {
      Console.WriteLine("###############################################################");
      Console.WriteLine($"Product name: {_name}");
      Console.WriteLine($"Product quantity: {_quantity}");
      Console.WriteLine($"Product cost: {_cost}$");
      Console.WriteLine("###############################################################");
    }
  }
  
  internal class Program
  {
    static void StudentProg()
    {
      Console.Write("How many students do you want to enter? -> ");
      uint studentCount = Convert.ToUInt32(Console.ReadLine());
      Student[] students = new Student[studentCount];
      for (int i = 1; i <= studentCount; ++i)
      {
        Console.WriteLine($"Enter student #{i} info:");
        Console.Write("Name -> ");
        string name = Console.ReadLine();
        Console.Write("Birth year -> ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Birth month -> ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Birth day -> ");
        int day = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[4];
        Console.Write("Chemistry grade -> ");
        grades[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("PE grade -> ");
        grades[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Science grade -> ");
        grades[2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Biology grade -> ");
        grades[3] = Convert.ToInt32(Console.ReadLine());
        students[i - 1] = new Student(name, new DateTime(year, month, day), grades);
      }
      
      Console.WriteLine();
      
      foreach (Student student in students)
      {
        if (student.IsYoung())
          student.PrintInfo();
      }
    }

    static void ShopProg()
    {
      Console.Write("How many products do you want to enter? -> ");
      uint productsCount = Convert.ToUInt32(Console.ReadLine());
      Product[] products = new Product[productsCount];
      for (int i = 1; i <= productsCount; ++i)
      {
        Console.WriteLine($"Enter product #{i} info:");
        Console.Write("Name -> ");
        string name = Console.ReadLine();
        Console.Write("Type -> ");
        string type = Console.ReadLine();
        Console.Write("Quantity -> ");
        uint quantity = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Cost -> ");
        uint cost = Convert.ToUInt32(Console.ReadLine());
        products[i - 1] = new Product(name, type, quantity, cost);
      }
      
      Console.WriteLine();
      
      foreach (Product product in products)
      {
        product.PrintInfo();
      }
    }

    public static void Main()
    {
      StudentProg();
      Console.WriteLine();
      ShopProg();
    }
  }
}
