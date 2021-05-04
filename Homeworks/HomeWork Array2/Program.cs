using System;

namespace HomeWork_Array2
{

  class Array2
  {
    int n;
    int m;
    int[,] numbers;
    int scalar;
    public Array2(int n, int m)
    {
      this.numbers = new int[n, m];
    }
    public int N
    {
      get
      {
        return n;
      }
      set
      {
        if (value > 0)
        {
          n = value;
        }
      }
    }
    public int M
    {
      get
      {
        return m;
      }
      set
      {
        if (value > 0)
        {
          m = value;
        }
      }
    }

    public int Count
    {
      get
      {
        int rows = numbers.GetUpperBound(0) + 1;
        int columns = numbers.GetUpperBound(1) + 1;
        int count = rows * columns;

        return count;
      }

    }

    public int Scalar
    {

      set
      {
       
      }
    }
    public void ArraySet(int n, int m)
    {

      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          Console.WriteLine($"Enter numbers {i} row and {j} column");
          numbers[i, j] = Convert.ToInt32(Console.ReadLine());
        }
      }
    }

    public void ArrayDisplay(int n, int m)
    {
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          Console.WriteLine(numbers[i, j]);
        }
      }
    }

    public void ArraySort(int n, int m)
    {
     
      int[] tempArray = new int[n*m];
      int z = 0;

      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          tempArray[z] = numbers[i, j];
          z++;

        }
      }
      int temp;
      for (int i = 0; i < numbers.Length - 1; i++)
      {
        for (int j = i + 1; j < numbers.Length; j++)
        {
          if (tempArray[i] < tempArray[j])
          {
            temp = tempArray[i];
            tempArray[i] = tempArray[j];
            tempArray[j] = temp;
          }
        }

      }

      for (int i = 0; i < z; i++)
      {
        Console.WriteLine($"index {i} = {tempArray[i]}");
      }

    }
    class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("Enter row length");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter column length");
        int m = Convert.ToInt32(Console.ReadLine());


        Array2 array2 = new Array2(n, m);

        array2.ArraySet(n, m);

        Console.WriteLine("Array elements");

        array2.ArrayDisplay(n, m);

        Console.WriteLine($"elements count is{array2.Count}");

        array2.ArraySort(n, m);

      }
    }
  }
}
