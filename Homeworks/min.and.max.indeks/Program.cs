using System;

namespace min.and.max.indeks
{
  
  class Program
  {
    static void Main(string[] args)
    {
      int length;

      for (; ; )
      {
        Console.WriteLine("Enter lenght");

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

      int min = numbers[0];
      int minIndex = 0;

      int max = numbers[0];
      int maxIndex = 0;


      for (int i = 0; i < length; i++)
      {
        if (min > numbers[i])
        {
          min = numbers[i];
          minIndex = i;
        }
        if (max < numbers[i])
        {
          max = numbers[i];
          maxIndex = i;
        }


      }

      Console.WriteLine($"minimal index is {minIndex}");
      Console.WriteLine($"maximal index is {maxIndex}");
      
      Console.ReadKey();
    }

  }
}

