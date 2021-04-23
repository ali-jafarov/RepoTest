using System;

namespace bubble
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

      int[] mass1 = new int[length];

      for (int i = 0; i < length; i++)
      {
        Console.WriteLine($"Enter {i} number");

        string input2 = (Console.ReadLine());

        if (Int32.TryParse(input2, out mass1[i]))
        {

        }
        else
        {
          Console.WriteLine("Некорректный ввод");
          i--;
        }
      }

      int temp;
      for (int i = 0; i < length - 1; i++)
      {
        for (int j = i + 1; j < length; j++)
        {
          if (mass1[i] > mass1[j])
          {
            temp = mass1[i];
            mass1[i] = mass1[j];
            mass1[j] = temp;
          }
        }
      }



      for (int i = 0; i < length; i++)
      {
        Console.WriteLine(mass1[i]);
      }

    }
  }
        
}


