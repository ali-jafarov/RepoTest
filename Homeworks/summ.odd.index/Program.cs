using System;

namespace summ.odd.index
{
  class Program
  {
    static void Main(string[] args)
    {
      int length;

      for (; ; )
      {
        Console.WriteLine("Enter length");

        string input = (Console.ReadLine());

        if (Int32.TryParse(input, out length) && length > 0)
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


      int sumOdd = 0;

      for (int i = 0; i < length; i++)
      {
        if (i % 2 != 0)
        {
          sumOdd += numbers[i];
        }
      }

      Console.WriteLine($"Сумма элементов массива с нечетными индексами = {sumOdd}");

      Console.ReadKey();
    }
  }
}



