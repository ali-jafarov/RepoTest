using System;

namespace HomeWork_Tirangle
{
  public class Triangle
  {
    private double a;
    private double b;
    private double c;
    public Triangle(double a, double b, double c)
    {
      this.a = a;
      this.b = b;
      this.c = c;
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

    public double C
    {
      get
      {
        return c;
      }
      set
      {
        if (value > 0)
        {
          c = value;
        }
      }
    }
    public bool Check()
    {
      if (a + b > c && c + a > b && c + b > a)
      {
        return true;
      }

      return false;
    }
    public string SideInfo(double a, double b, double c)
    {
      return ($"Сторона треугольника А равна {a}, сторона В равна {b}, сторона С равна {c}");
    }
    public double Perimetr(double a, double b, double c)
    {

      double p = a + b + c;

      return p;
    }
    public double Area(double a, double b, double c)
    {
      double temp = Perimetr(a, b, c) / 2;
      double s = Math.Sqrt(temp * (temp - a) * (temp - b) * (temp - c));

      return s;
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
      double c = 0;
      string input;
      bool isInputValid;
      bool isTriangleValid;

      Triangle triangle = new Triangle(a, b, c);

      do
      {
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
            triangle.A = a;
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
            triangle.B = b;
          }
        } while (isInputValid != true);

        do
        {
          Console.WriteLine("Enter side C");
          input = (Console.ReadLine());

          isInputValid = CheckInput(input, out c);

          if (isInputValid != true)
          {
            Console.WriteLine("Invalid input");
          }
          else
          {
            triangle.C = c;
          }
        } while (isInputValid != true);

        isTriangleValid = triangle.Check();

        if (isTriangleValid != true)
        {
          Console.WriteLine("Треугольника с такими сторонами не существует");
        }
      } while (isTriangleValid == false);


      
      Console.WriteLine(triangle.SideInfo(triangle.A, triangle.B, triangle.C));

      
      Console.WriteLine($"Периметр треугольника равен {triangle.Perimetr(triangle.A, triangle.B, triangle.C)}");

      
      Console.WriteLine($"Площадь треугольника равна {triangle.Area(triangle.A, triangle.B, triangle.C)}");


    }
  }
}
