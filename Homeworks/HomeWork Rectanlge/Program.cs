using System;

namespace HomeWork_Rectanlge
{

  public class Rectangle
  {
    private double a;
    private double b;

    public Rectangle(double a, double b)
    {
      this.a = a;
      this.b = b;
    }

    public double A
    {
      get
      {
        return a;
      }
      set
      {
        if (value > 0)
        {
          a = value;
        }
      }
    }

    public double B
    {
      get
      {
        return b;
      }
      set
      {
        if (value > 0)
        {
          b = value;
        }
      }
    }
    public bool C
    {
      get
      {
        return a == b;
      }
    }
    public string SideInfo(double a, double b)
    {
      return ($"Сторона А равна {a}, сторона B равна {b}");
    }

    public double Perimetr(double a, double b)
    {
      return a * 2 + b * 2;
    }

    public double Area(double a, double b)
    {
      return a * b;
    }


  }
  class Program
  {
    public static bool CheckInput(string input, out double side)
    {
      if (Double.TryParse(input, out side) && side > 0)
      {
        return true;
      }
      return false;
    }
    static void Main(string[] args)
    {
      double a = 0;
      double b = 0;
      string input;
      bool isInputValid;

      Rectangle rectangle = new Rectangle(a, b);



      do
      {
        Console.WriteLine("Enter side A");
        input = (Console.ReadLine());

        isInputValid = CheckInput(input, out a);

        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }
        else
        {
          rectangle.A = a;
        }
      } while (isInputValid != true);

      do
      {
        Console.WriteLine("Enter side B");
        input = (Console.ReadLine());

        isInputValid = CheckInput(input, out b);

        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }
        else
        {
          rectangle.B = b;
        }
      } while (isInputValid != true);

      string sideInfo = rectangle.SideInfo(rectangle.A, rectangle.B);
      Console.WriteLine(sideInfo);

      double perimetr = rectangle.Perimetr(rectangle.A, rectangle.B);
      Console.WriteLine($"Периметр равен {perimetr}");

      double area = rectangle.Area(rectangle.A, rectangle.B);
      Console.WriteLine($"Площадь равна {area}");

      if (rectangle.C)
      {
        Console.WriteLine("Фигура является квадратом");
      }
      else
      {
        Console.WriteLine("Фигура является прямоугольником");
      }


    }
  }
}
