using System;

namespace PowerAndPowerSum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your number");
      int number = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter your power");
      int power = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      Console.WriteLine("Power: " + Power(power, number, ref sum));
      Console.WriteLine("Sum of power: " + sum);
      Console.ReadKey();
    }

    public static int Power(int power, int number, ref int sum)
    {
      if (power == 0)
      {
        sum -= number;
        return 1;
      }

      var result = number * Power(power - 1, number, ref sum);

      sum += result;

      return result;
    }
  }
}
