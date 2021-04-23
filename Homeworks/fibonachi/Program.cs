using System;

namespace fibonachi
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] mass = new int[20];
      mass[0] = 0;
      mass[1] = 1;


      for (int i = 2; i < 20; i++)
      {
        mass[i] = mass[i - 1] + mass[i - 2];
      }

      for (int i = 0; i < 20; i++)
      {
        Console.WriteLine(mass[i]);
      }
    }

  }
}