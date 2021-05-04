using System;

namespace HomeWork_Money
{
  class Money
  {
    int nom;
    int quantity;
    
    public Money(int nom, int quantity)
    {
      this.nom = nom;
      this.quantity = quantity;
    }

    public int Nom 
    {
      get 
      {
        return nom;
      }
      set 
      {
        if (value > 0)
        {
          nom = value;

        }
      }
    }

    public int Quantity
    {
      get
      {
        return quantity;
      }
      set
      {
        if (value > 0)
        {
          quantity = value;

        }
      }
    }

   
    public int Sum 
    {
      get 
      {
        return nom * quantity;
      }
    }

    public string GetInfo(int nom, int quantity)
    {
      return ($"У вас {quantity} купюр по {nom} АЗН");
    }
    
    

    public int Goods(int nom, int quantity) 
    {

      return nom * quantity;
    }
  }
  class Program
  {
    public static bool CheckInput(string input, out int num)
    {
      if (Int32.TryParse(input, out num) && num > 0)
      {
        return true;
      }
      return false;
    }
    static void Main(string[] args)
    {
      int nom = 0;
      int quantity = 0;
      int price;
      string input;
      bool isInputValid;

      Money money = new Money(nom, quantity);

      do
      {
        Console.WriteLine("Введите номинал");
        input = (Console.ReadLine());

        isInputValid = CheckInput(input, out nom);

        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }
        else
        {
          money.Nom = nom;
        }
      } while (isInputValid != true);

      do
      {
        Console.WriteLine("Введите количество купюр");
        input = (Console.ReadLine());

        isInputValid = CheckInput(input, out quantity);

        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }
        else
        {
          money.Quantity = quantity;
        }
      } while (isInputValid != true);
      
      Console.WriteLine($"Сумма наличных составляет {money.Sum}");
      
      do
      {
        Console.WriteLine("Введите цену товара");
        input = (Console.ReadLine());

        isInputValid = CheckInput(input, out price);

        if (isInputValid != true)
        {
          Console.WriteLine("Invalid input");
        }
        
      } while (isInputValid != true);

        Console.WriteLine($"Допустимое количестов товара {money.Sum/price} штук");
      
      

    }
  }
}
