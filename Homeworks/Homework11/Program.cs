using System;

namespace Homework11

{
  public class Program
  {
    static void Main(string[] args)
    {
      bool check;
      string name1 = "";
      string name2 = "";
      do
      {
        Console.WriteLine("Enter name of first person");
        check = true;
        name1 = (Console.ReadLine());

        for (int i = 0; i < name1.Length; i++)
        {
          if (int.TryParse(name1[i].ToString(), out int number))
          {
            Console.WriteLine("Invalid input");
            check = false;
            break;
          }
        }
      } while (check == false);


      int age1;
      while (true)
      {
        Console.WriteLine("Enter age of first person");
        string input = (Console.ReadLine());

        if (Int32.TryParse(input, out age1) && age1 > 0)
        {
          break;
        }
        else
        {
          Console.WriteLine("Invalid input");
          continue;
        }
      }

      do
      {
        Console.WriteLine("Enter name of second person");
        check = true;

        name2 = Console.ReadLine();

        for (int i = 0; i < name2.Length; i++)
        {
          if (int.TryParse(name2[i].ToString(), out int number))
          {
            Console.WriteLine("Invalid input");
            check = false;
            break;
          }
        }
      } while (check == false);

      int age2;

      while (true)
      {
        Console.WriteLine("Enter age of second person");
        string input = (Console.ReadLine());

        if (Int32.TryParse(input, out age2) && age2 > 0)
        {
          break;
        }
        else
        {
          Console.WriteLine("Invalid input");
          continue;
        }
      }

      do
      {
        Console.WriteLine("Who do you think is older?");
        check = true;

        string older = (Console.ReadLine());

        for (int i = 0; i < older.Length; i++)
        {
          if (int.TryParse(older[i].ToString(), out int number))
          {
            Console.WriteLine("Invalid input");
            check = false;
            break;
          }
        }

        if (older == name1)
        {
          if (age1 > age2)
          {
            int ageResult1 = age1 - age2;
            Console.WriteLine($"U r right {name1} is older by {ageResult1} years");
          }
          else
          {
            Console.WriteLine("U r wrong");
          }
        }
        else if (older == name2)
        {
          if (age2 > age1)
          {
            int ageResult2 = age2 - age1;
            Console.WriteLine($"U r right {name2} is older by {ageResult2} years");
          }
          else
          {
            Console.WriteLine("U r wrong");
          }
        }

        if (older != name1 && older != name2)
        {
          Console.WriteLine("Wrong name");
        }
        else if (age1 == age2)
        {
          Console.WriteLine("they are peers");
        }

      } while (check == false);
      Console.ReadKey();
    }
  }
}