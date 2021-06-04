using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework_Collections
{
  abstract class Person
  {

    public Person(string name, string surname)
    {
      Name = name;
      Surname = surname;
    }
    public string Name { get; set; }

    public string Surname { get; set; }

    public virtual string Print()
    {
      return $"Имя: {Name}, Фамилия: {Surname}";
    }

  }

  class Student : Person
  {


    public string DocNumber { get; set; }
    public int Year { get; set; }
    public Student(string name, string surname, int year, string docNumber) : base(name, surname)
    {
      Year = year;
      DocNumber = docNumber;
    }
    public override string Print()
    {
      return base.Print() + $", Документ: {DocNumber}, Курс: {Year}";
    }
  }
  class Aspirant : Person
  {

    public string DocNumber { get; set; }
    public int Year { get; set; }
    public string Diplom { get; set; }
    public Aspirant(string name, string surname, int year, string docNumber, string diplom) : base(name, surname)
    {
      Year = year;
      DocNumber = docNumber;
      Diplom = diplom;
    }
    public override string Print()
    {
      return base.Print() + $", Документ: {DocNumber}, Курс: {Year}, Диплом: {Diplom}";
    }
  }
  public class Menu
  {
    private string validNameSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    ArrayList students = new ArrayList();
    private LinkedList<Aspirant> aspirants = new LinkedList<Aspirant>();
    public void MainMenu()
    {
      while (true)
      {
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Выберите команду:");
        Console.WriteLine("1.  Для добавления нового студента.");
        Console.WriteLine("2.  Для добавления нового аспиранта.");
        Console.WriteLine("3.  Для вывода кол-ва студентов.");
        Console.WriteLine("4.  Для вывода кол-ва аспирантов.");
        Console.WriteLine("5.  Для вывода списка студентов.");
        Console.WriteLine("6.  Для вывода списка аспирантов.");
        Console.WriteLine("7.  Для вывода студента по порядковому индексу.");
        Console.WriteLine("8.  Для реверса списка студентов");
        Console.WriteLine("9.  Для удаления студента.");
        Console.WriteLine("10. Для удаления аспиранта.");
        Console.WriteLine("0.  Для того чтобы завершить работу.");
        var input = Console.ReadLine();

        if (int.TryParse(input, out var operationNumber) == false || operationNumber > 10 || operationNumber < 0)
        {
          Console.WriteLine("vi vveli neverniy nomer operacii");
          Console.ReadKey();
          continue;
        }

        if (operationNumber == 1)
        {
          var student = CreateStudent();
          AddStudent(student);
        }
        else if (operationNumber == 2)
        {
          var aspirant = CreateAspirant();
          AddAspirant(aspirant);
        }

        else if (operationNumber == 3)
        {
          Console.WriteLine(students == null ? "список студентов пуст" : $"Кол-во студентов: {students.Count}");
        }

        else if (operationNumber == 4)
        {
          Console.WriteLine(aspirants == null ? "список аспирантов пуст" : $"Кол-во аспирантов: {aspirants.Count}");
        }

        else if (operationNumber == 5)
        {
          if (students == null)
          {
            Console.WriteLine("Вы не добавили ни одного студента");
            continue;
          }

          for (int i = 0; i < students.Count; i++)
          {
            Console.WriteLine((students[i] as Student).Print());
          }


        }

        else if (operationNumber == 6)
        {
          if (aspirants == null)
          {
            Console.WriteLine("Вы не добавили ни одного аспиранта");
            continue;
          }

          foreach (var aspirant in aspirants)
          {
            Console.WriteLine(aspirant.Print());
          }
        }
        else if (operationNumber == 7)
        {
          PrintStudent();
        }

        else if (operationNumber == 8)
        {
          students.Reverse();
        }

        else if (operationNumber == 9)
        {
          DelStudent();
        }

        else if (operationNumber == 10)
        {
          DelAspirant();
        }

        else if (operationNumber == 0)
          return;
      }
    }
    Student CreateStudent()
    {
      Console.WriteLine("Введите имя студента: ");
      var input = Console.ReadLine();

      if (CheckName(input) == false)
      {
        Console.WriteLine("Вы ввели некоректное имя");

        return null;
      }

      var name = input;

      Console.WriteLine("Введите фамилию студента: ");
      input = Console.ReadLine();

      if (CheckName(input) == false)
      {
        Console.WriteLine("Вы ввели некоректную фамилию");

        return null;
      }

      var surname = input;

      Console.WriteLine("Введите номер документа студента: ");
      input = Console.ReadLine();

      var docNumber = input;

      Console.WriteLine("Введите курс студента: ");
      input = Console.ReadLine();

      if (int.TryParse(input, out var year) && year > 0 && year < 5)
      {
        Console.WriteLine("Студент создан");

        return new Student(name, surname, year, docNumber);
      }

      Console.WriteLine("Вы ввели неверный курс студента");
      return null;
    }


    private void AddStudent(Student student)
    {
      students.Add(student);
    }

    private bool DelStudent()
    {
      Console.WriteLine("Введите индекс студента которого хотите удалить");
      var input = Console.ReadLine();

      if (int.TryParse(input, out var index) == false)
      {
        Console.WriteLine("Индекс должен быть числом");
        return false;
      }

      if (students == null)
      {
        Console.WriteLine("Список студентов пуст");
        return false;
      }

      if (index >= students.Count || index < 0)
      {
        Console.WriteLine("Неверный индекс студента");
        return false;
      }

      if (students.Count == 1)
      {
        students = null;
        return true;
      }

      students.RemoveAt(index);
      return true;
    }

    public bool PrintStudent()
    {
      Console.WriteLine("Введите индекс студента");

      var input = Console.ReadLine();
      if (int.TryParse(input, out var index) == false)
      {
        Console.WriteLine("Индекс должен быть числом");
        return false;
      }
      if (students == null)
      {
        Console.WriteLine("Список студентов пуст");
        return false;
      }
      if (index >= students.Count || index < 0)
      {
        Console.WriteLine("Неверный индекс студента");
        return false;
      }

      Console.WriteLine((students[index] as Student).Print());
      return true;
    }

    Aspirant CreateAspirant()
    {
      Console.WriteLine("Введите имя аспиранта: ");
      var input = Console.ReadLine();

      if (CheckName(input) == false)
      {
        Console.WriteLine("Вы ввели некоректное имя");

        return null;
      }

      var name = input;

      Console.WriteLine("Введите фамилию аспиранта: ");
      input = Console.ReadLine();

      if (CheckName(input) == false)
      {
        Console.WriteLine("Вы ввели некоректную фамилию");

        return null;
      }

      var surname = input;

      Console.WriteLine("Введите номер документа аспиранта: ");
      input = Console.ReadLine();

      var docNumber = input;

      Console.WriteLine("Введите тему дипломной работы: ");
      input = Console.ReadLine();

      var diplom = input;

      Console.WriteLine("Vvedite kurs aspiranta: ");
      input = Console.ReadLine();

      if (int.TryParse(input, out var year) && year > 0 && year < 5)
      {
        Console.WriteLine("Аспирант создан");

        return new Aspirant(name, surname, year, docNumber, diplom);
      }

      Console.WriteLine("Вы ввели неверный курс аспиранта");
      return null;
    }
    private void AddAspirant(Aspirant aspirant)
    {
      aspirants.AddLast(aspirant);
    }

    private bool DelAspirant()
    {
      aspirants.RemoveFirst();
      return true;
    }


    private bool CheckName(string name)
    {
      foreach (var m in name)
      {
        if (validNameSymbols.Contains(m) == false)
          return false;
      }

      return true;
    }
  }

  class Program
  {

    static void Main(string[] args)
    {
      var menu = new Menu();
      menu.MainMenu();
    }
  }
}
