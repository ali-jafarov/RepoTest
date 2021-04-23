using System;

namespace min.max.element
{
  class Program
  {
    static void Main(string[] args)
    {
      int length;

      for (; ; )
      {
        Console.WriteLine("Enter size");

        string input = (Console.ReadLine());

        if (Int32.TryParse(input, out length))
        {
          break;
        }
        else
        {
          Console.WriteLine("Некорректный ввод");
          continue;
        }

      }

      int[] numbers = new int[length];

      for (int i = 0; i < length; i++)
      {
        Console.WriteLine($"Enter {i} number");

        string input2 = (Console.ReadLine());

        if (Int32.TryParse(input2, out numbers[i]))
        {
        }
        else
        {
          Console.WriteLine("Некорректный ввод");
          i--;
        }
      }

      int minValue = numbers[0];
      int maxValue = numbers[0];

      for (int i = 1; i < length; i++)
      {
        if (minValue > numbers[i])
        {
          minValue = numbers[i];

        }
        if (maxValue < numbers[i])
        {
          maxValue = numbers[i];

        }

      }

      Console.WriteLine($"minimal value is {minValue}");
      Console.WriteLine($"maximal value is {maxValue}");

    }
  }
}