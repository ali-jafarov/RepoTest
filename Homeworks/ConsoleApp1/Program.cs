using System;

namespace Задание_2
{
  class Account
  {
    private decimal accountMoney;
    private int accountNumber;
    private int day;
    private int month;
    private int year;

    public decimal Sum
    {
      get { return accountMoney; }
      set { accountMoney = value; }
    }

    public int Number
    {
      get { return accountNumber; }
      set { accountNumber = value; }
    }

    public int Day
    {
      get { return day; }
      set
      {
        for (; ; )
        {
          if (value > 31 || (value > 28 && month == 2) || (value > 30 && month == 4) || (value > 30 && month == 6) || (value > 30 && month == 9) || (value > 30 && month == 11))
          {
            Console.WriteLine("Вы ввели не правильный день");
            value = TestNumber();
          }
          else { day = value; break; }
        }
      }
    }

    public int Month
    {
      get { return month; }
      set
      {
        for (; ; )
        {

          if (value > 12)
          {
            Console.WriteLine("Вы ввели не правильный месяц");
            value = TestNumber();
          }
          else { month = value; break; }
        }
      }
    }

    public int Year
    {
      get { return year; }
      set
      {
        for (; ; )
        {

          if (value > 2021)
          {
            Console.WriteLine("Вы ввели не правильный год");
            value = TestNumber();
          }
          else { year = value; break; }
        }
      }
    }

    public virtual void DateDisplay()
    {
      DateTime date1 = new DateTime(Year, Month, Day);

      Console.WriteLine($"Дата открытия счёта {date1.Year}.{date1.Month}.{date1.Day}");
    }

    public Account()
    {

    }
    public Account(decimal account_money, int account_number, int day, int month, int year)
    {
      this.Number = account_number;
      this.Sum = account_money;
      this.Day = day;
      this.Month = month;
      this.Year = year;

    }

    protected int TestNumber()
    {
      int test;
      string number = Console.ReadLine();
      for (; ; )
      {
        if (Int32.TryParse(number, out test) && test > 0)
        {
          return test;
        }
        else
        {
          Console.WriteLine("Введите корректное число");
          number = Console.ReadLine();
        }
      }
    }
  }







  class Individual : Account
  {
    private int cardType;
    protected string message;





    public override void DateDisplay()
    {
      DateTime date1 = new DateTime(Year, Month, Day);

      Console.WriteLine("Дата открытия счёта " + date1.ToShortDateString());
    }





    public void CardTypeChoose()
    {
      Console.WriteLine("Выберите тип карты");
      Console.WriteLine("(1) Депозитный счет\n(2) Лицевой счет\n(3) Карточный счет\n(4) Расчетный счет");
      Console.WriteLine("\nВведите выбранный счёт");
      cardType = TestNumber();

      bool checkSwitch = true;
      do
      {
        switch (cardType)
        {
          case 1: { message = "Депозитный счет"; checkSwitch = false; break; }
          case 2: { message = "Лицевой счет"; checkSwitch = false; break; }
          case 3: { message = "Карточный счет"; checkSwitch = false; break; }
          case 4: { message = "Расчетный счет"; checkSwitch = false; break; }
          default: { Console.WriteLine("Введите корректное число"); break; }

        }

      } while (checkSwitch);

      Console.WriteLine("Вы выбрали " + message);
    }











    public void CashWithdrawal()
    {
      decimal temp;
      Console.WriteLine($"Тип счёта: {message}\nБаланс вашего счёта составляет {Sum} \nВведите сколько желаете снять наличных");
      temp = TestNumber();

      for (; ; )
      {
        if (temp > Sum)
        {
          Console.WriteLine("Вы ввели сумму наличных больше чем у вас на счету\nВведите правильную сумму:");
          temp = TestNumber();
        }
        else
        {
          Sum = Sum - temp;
          Console.WriteLine("Выдача наличных, просим подождать...");
          Console.WriteLine($"Ваша остаток на счету составляет {Sum}");
          break;
        }
      }

    }









    public virtual void InterestAccrual()
    {
      Console.WriteLine("Введите за сколько месяцев вы хотите посчитать начисление процента (процентная ставка равна 3%)");
      int temp = TestNumber();
      for (int i = 0; i < temp; i++)
      {
        Sum = Sum + Sum * 3 / 100;
      }
      Console.WriteLine($"Тип счёта: {message}\nСумма денег с учётом начисления за {temp} месяцев равна {Sum}");
    }





    public Individual()
    {

    }
    public Individual(decimal Sum, int Number, int Day, int Month, int Year) : base(Sum, Number, Day, Month, Year)
    {

    }
  }




































































  class LegalEntity : Individual
  {
    public override void DateDisplay()
    {

      DateTime date1 = new DateTime(Year, Month, Day);

      Console.WriteLine("Дата открытия счёта " + date1.ToShortDateString());
    }

    public override void InterestAccrual()
    {
      Console.WriteLine("Введите за сколько месяцев вы хотите посчитать начисление процента (процентная ставка равна 10%)");
      int temp = TestNumber();
      for (int i = 0; i < temp; i++)
      {
        Sum = Sum + Sum * 10 / 100;
      }
      Console.WriteLine($"Тип счёта: {message}\nСумма денег с учётом начисления за {temp} месяцев равна {Sum}");
    }
    public LegalEntity() { }
    public LegalEntity(decimal Sum, int Number, int Day, int Month, int Year) : base(Sum, Number, Day, Month, Year)
    {

    }
  }










  class Program
  {
    static void Main(string[] args)
    {
      int typeChoose;
      Console.WriteLine("Выберите какое вы лицо:\n(1) Физическое лицо\n(2) Юридическое лицо \n\nВведите выбранный вариант");

      do
      {
        typeChoose = TestNumber();
        if (typeChoose > 2)
        {
          Console.WriteLine("Введите корректное число");
        }
      }
      while (typeChoose > 2);

      switch (typeChoose)
      {
        case 1:
          {
            Individual client = new Individual();
            Console.WriteLine("Выберите операцию:\n(1) Выдача денег\n(2) Расчёт месячной процентной ставки\n\nВведите выбранный вариант");
            int number;
            do
            {
              number = TestNumber();
              if (number > 2)
              {
                Console.WriteLine("Введите корректное число");
              }
            }
            while (number > 2);

            switch (number)
            {


              case 1:
                {
                  client.CardTypeChoose();
                  Console.WriteLine("Введите сколько у вас денег на счету");
                  client.Sum = TestNumber();
                  Console.WriteLine("Введите номер счёта");
                  client.Number = TestNumber();
                  Console.WriteLine("Введите дату открытия карты");
                  Console.WriteLine("Год");
                  client.Year = TestNumber();
                  Console.WriteLine("Месяц");
                  client.Month = TestNumber();
                  Console.WriteLine("День");
                  client.Day = TestNumber();
                  client.DateDisplay();
                  client.CashWithdrawal();
                  break;
                }
              case 2:
                {
                  client.CardTypeChoose();
                  Console.WriteLine("Введите сколько у вас денег на счету");
                  client.Sum = TestNumber();
                  Console.WriteLine("Введите номер счёта");
                  client.Number = TestNumber();
                  Console.WriteLine("Введите дату открытия карты");
                  Console.WriteLine("Год");
                  client.Year = TestNumber();
                  Console.WriteLine("Месяц");
                  client.Month = TestNumber();
                  Console.WriteLine("День");
                  client.Day = TestNumber();
                  client.DateDisplay();
                  client.InterestAccrual();
                  break;
                }
            }
            break;
          }
        case 2:
          {
            Individual client = new LegalEntity();
            Console.WriteLine("Выберите операцию:\n(1) Расчёт месячной процентной ставки\n\nВведите выбранный вариант");
            int number;

            do
            {
              number = TestNumber();
              if (number > 1)
              {
                Console.WriteLine("Введите корректное число");
              }
            }
            while (number > 1);

            switch (number)
            {
              case 1:
                {
                  client.CardTypeChoose();
                  Console.WriteLine("Введите сколько у вас денег на счету");
                  client.Sum = TestNumber();
                  Console.WriteLine("Введите номер счёта");
                  client.Number = TestNumber();
                  Console.WriteLine("Введите дату открытия карты");
                  Console.WriteLine("Год");
                  client.Year = TestNumber();
                  Console.WriteLine("Месяц");
                  client.Month = TestNumber();
                  Console.WriteLine("День");
                  client.Day = TestNumber();

                  client.DateDisplay();
                  client.InterestAccrual();
                  break;
                }
            }
            break;
          }
        default:
          {
            Console.WriteLine("Вы ввели некоректные данные");
            break;
          }
      }
    }


    static int TestNumber()
    {
      int test;
      string number = Console.ReadLine();
      for (; ; )
      {
        if (Int32.TryParse(number, out test) && test > 0)
        {
          return test;
        }
        else
        {
          Console.WriteLine("Введите корректное число");
          number = Console.ReadLine();
        }
      }
    }
  }
}