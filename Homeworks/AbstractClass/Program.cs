using System;

namespace AbstractClass
{

  abstract class Person
  {
    private string name;
    private string surname;

    public Person(string name, string surname)
    {
      this.name = name;
      this.surname = surname;
    }
    public string Name {get; set;}
    public string Surname { get; set; }


    public virtual string Print()
    {
      return $"Имя: {Name}, Фамилия: {Surname}";
    }

  }

  class Student : Person
  {
    private int year;
    private string docNumber;

    public string DocNumber { get; set; }


    public int Year { get; set; }


    public Student(string name, string surname, int year, string docNumber) : base(name, surname)
    {
      this.year = year;
      this.docNumber = docNumber;
    }

    public override string Print()
    {
      return base.Print() + $", Документ: {docNumber}, Курс: {year}";
    }
  }

  class Aspirant : Person
  {
    private string diplom;
    private int year;
    private string docNumber;

    public string DocNumber { get; set; }


    public int Year { get; set; }


    public string Diplom { get; set; }

    public Aspirant(string name, string surname, int year, string docNumber, string diplom) : base(name, surname)
    {
      this.year = year;
      this.docNumber = docNumber;
      this.diplom = diplom;
    }

    public override string Print()
    {
      return base.Print() + $", Документ: {docNumber}, Курс: {year}, Диплом: {diplom}";
    }
  }
  public class Menu
  {
    private string validNameSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    private Student[] students;
    private Aspirant[] aspirants;
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
        Console.WriteLine("8.  Для вывода аспиранта по порядковому индексу.");
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
          Console.WriteLine(students == null ? "список студентов пуст" : $"Кол-во студентов: {students.Length}");
        }

        else if (operationNumber == 4)
        {
          Console.WriteLine(aspirants == null ? "список аспирантов пуст" : $"Кол-во аспирантов: {aspirants.Length}");
        }

        else if (operationNumber == 5)
        {
          if (students == null)
          {
            Console.WriteLine("Вы не добавили ни одного студента");
            continue;
          }

          foreach (var student in students)
          {
            Console.WriteLine(student.Print());
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
          PrintAspirant();
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
      if (students == null)
      {
        students = new Student[1];
        students[0] = student;
        return;
      }

      var studentsBuffer = new Student[students.Length + 1];

      for (int i = 0; i < students.Length; i++)
      {
        studentsBuffer[i] = students[i];
      }

      studentsBuffer[studentsBuffer.Length - 1] = student;
      students = studentsBuffer;
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

      if (index >= students.Length || index < 0)
      {
        Console.WriteLine("Неверный индекс студента");
        return false;
      }

      if (students.Length == 1)
      {
        students = null;
        return true;
      }

      Student[] temp = new Student[students.Length - 1];
      int j = 0;
      for (int i = 0; i < students.Length; i++)
      {
        if (i == index)
        {
          continue;
        }

        temp[j] = students[i];
        j++;
      }

      students = temp;
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
      if (index >= students.Length || index < 0)
      {
        Console.WriteLine("Неверный индекс студента");
        return false;
      }

      Console.WriteLine(students[index].Print());
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
      if (aspirants == null)
      {
        aspirants = new Aspirant[1];
        aspirants[0] = aspirant;
        return;
      }

      var aspirantBuffer = new Aspirant[aspirants.Length + 1];

      for (int i = 0; i < aspirants.Length; i++)
      {
        aspirantBuffer[i] = aspirants[i];
      }

      aspirantBuffer[aspirantBuffer.Length - 1] = aspirant;
      aspirants = aspirantBuffer;
    }

    private bool DelAspirant()
    {
      Console.WriteLine("Введите индекс аспиранта которого хотите удалить");
      var input = Console.ReadLine();

      if (int.TryParse(input, out var index) == false)
      {
        Console.WriteLine("Индекс должен быть числом");
        return false;
      }

      if (students == null)
      {
        Console.WriteLine("Список аспирантов пуст");
        return false;
      }

      if (index >= aspirants.Length || index < 0)
      {
        Console.WriteLine("Неверный индекс аспиранта");
        return false;
      }

      if (aspirants.Length == 1)
      {
        students = null;
        return true;
      }

      Aspirant[] temp = new Aspirant[aspirants.Length - 1];
      int j = 0;
      for (int i = 0; i < aspirants.Length; i++)
      {
        if (i == index)
        {
          continue;
        }

        temp[j] = aspirants[i];
        j++;
      }
      aspirants = temp;
      return true;
    }

    public bool PrintAspirant()
    {
      Console.WriteLine("Введите индекс аспиранта");

      var input = Console.ReadLine();
      if (int.TryParse(input, out var index) == false)
      {
        Console.WriteLine("Индекс должен быть числом");
        return false;
      }
      if (aspirants == null)
      {
        Console.WriteLine("Список аспирантов пуст");
        return false;
      }
      if (index >= aspirants.Length || index < 0)
      {
        Console.WriteLine("Неверный индекс аспиранта");
        return false;
      }

      Console.WriteLine(aspirants[index].Print());
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
