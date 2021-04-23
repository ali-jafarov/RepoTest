using System;

namespace revers.mass
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] mass1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      int[] mass2 = new int[10];



      for (int i = 9; i >= 0; i--)
      {
        mass2[i] = mass1[i];
        Console.WriteLine(mass2[i]);
      }

    }

  }
}
