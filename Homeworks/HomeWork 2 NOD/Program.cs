using System;

namespace HomeWork_2_NOD
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter first number");
      int num1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter second number");
      int num2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(Nod(num1, num2));
    }
    public static int Nod(int num1, int num2)
    {
      if (num1 % num2 == 0)
        return num2;

      else
        return Nod(num2, num1 % num2);
    }
  }
}