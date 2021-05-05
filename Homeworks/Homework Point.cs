using System;

namespace Homework_Point
{
  public class Point
  {
    private int x;
    private int y;

    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public Point()
    {

    }



    public int X
    {
      get
      {
        return x;
      }
      set
      {
        x = value;
      }
    }
    public int Y
    {
      get
      {
        return y;
      }
      set
      {
        y = value;
      }
    }
    public void DisplayDot()
    {
      Console.WriteLine($"Координаты точки A {x},{y}");
    }

    public double Dot()
    {
      double a = Math.Sqrt(x * x + y * y);
      return a;
    }

    public double Vector()
    {

    }

  }


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine();
    }
  }
}