using System;

namespace HomeWork_4_RangeSum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter first number");
      int num1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter Second number");
      int num2 = Convert.ToInt32(Console.ReadLine());

      int result;

      if (num2 > num1)
      {
        result = RangeSum(num2, num1);
      }
      else
      {
        result = RangeSum(num1, num2);
      }

      Console.WriteLine(result);

      Console.ReadKey();
    }



    public static int RangeSum(int num1, int num2)
    {
      int range = num1 - num2;
      if (range == 0)
        return range;

      return range + RangeSum(num1 - 1, num2);
    }

  }
}
