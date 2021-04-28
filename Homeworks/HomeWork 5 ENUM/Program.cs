using System;

namespace HomeWork_5_ENUM
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter day of week");

      
      int x = Convert.ToInt32(Console.ReadLine());
      if (x < 0 || x > 7)
      {
        Console.WriteLine("Invalid Input");
      }
      else 
      { 
        Days number = (Days)x;
        Console.WriteLine(number);
      }
    }

    enum Days
    {
      Monday =1,
      Tuesday,
      Wednesday,
      Thursday,
      Friday,
      Saturday,
      Sunday
    }
  }
}
