using System;

namespace summ.odd.elements
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


      int count = 0;

      for (int i = 0; i < length; i++)
      {
        if (numbers[i] % 2 != 0)
          count++;
      }

      Console.WriteLine($"количество нечетных элементов массива = {count}");
      
      Console.ReadKey();
    }
  }
}
