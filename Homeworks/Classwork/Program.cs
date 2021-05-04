using System;

namespace Classwork
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your salary");
      double salary = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter month");
      int month = Convert.ToInt32(Console.ReadLine());

      int percent = 23;

      double net = salary * 100 / (100 - percent);
      double percentNum = (net - salary)*month;

      double sumSalary = net * month;
      Console.WriteLine($"{net}");
      Console.WriteLine($"Sum of salary{sumSalary}");
      Console.WriteLine($"Sum of percent{percentNum}");









    }
  }
}
