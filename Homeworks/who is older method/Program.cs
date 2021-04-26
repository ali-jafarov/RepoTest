using System;

namespace who_is_older_method
{
  class Program
  {
    static void Main(string[] args)
    {
      bool isInputValid;
      string name;
      string name2;
      int age;
      int age2;
      string input;
      bool check;

      do
      {
        Console.WriteLine("Enter name of first person");

        name = (Console.ReadLine());

        isInputValid = CheckName(name);
        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }
      } while (isInputValid != true);

      do
      {
        Console.WriteLine("Enter name of second person");

        name2 = (Console.ReadLine());

        isInputValid = CheckName(name2);
        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }
      } while (isInputValid != true);

      do
      {
        Console.WriteLine("Enter age of first person");
        input = (Console.ReadLine());

        isInputValid = CheckAge(input, out age);

        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }

      } while (isInputValid != true);

      do
      {
        Console.WriteLine("Enter age of second person");
        input = (Console.ReadLine());

        isInputValid = CheckAge(input, out age2);

        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }

      } while (isInputValid != true);

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

        if (older == name)
        {
          if (age > age2)
          {
            int ageResult1 = age - age2;
            Console.WriteLine($"U r right {name} is older by {ageResult1} years");
          }
          else
          {
            Console.WriteLine("U r wrong");
          }
        }
        else if (older == name2)
        {
          if (age2 > age)
          {
            int ageResult2 = age2 - age;
            Console.WriteLine($"U r right {name2} is older by {ageResult2} years");
          }
          else
          {
            Console.WriteLine("U r wrong");
          }
        }

        if (older != name && older != name2)
        {
          Console.WriteLine("Wrong name");
        }
        else if (age == age2)
        {
          Console.WriteLine("they are peers");
        }

      } while (check == false);


    }


    static bool CheckName(string name)
    {

      for (int i = 0; i < name.Length; i++)
      {
        if (int.TryParse(name[i].ToString(), out int number))
        {
          return false;
        }
      }

      return true;
    }

    static bool CheckAge(string input, out int age)
    {
      if (Int32.TryParse(input, out age) && age > 0)
      {
        return true;
      }
      return false;
    }

  }
}

