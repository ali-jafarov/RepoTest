using System;

namespace HomeWork_Massive
{
  class Massive1 
  {
    private int[] numbers;
    private int n;
    private int i;
    private int scalar;
    public Massive1(int n)
    {
      this.numbers = new int[n];
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

    public int I
    {
      get
      {
        return i;
      }
      set
      {
        if (value > 0)
        {
          i = value;
        }
      }
    }
    public int Scalar 
    {

      set
      {
        for (int i = 0; i < numbers.Length; i++)
        {
          numbers[i] *= scalar;
        }
      }
    }
    public void MassSet()
    {
      
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine("Enter numbers");
        numbers [i] = Convert.ToInt32(Console.ReadLine());
      }
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine($"index {i} = {numbers[i]}");
      }
    }
    public void MassSort() 
    {
      int temp;
      for (int i = 0; i < numbers.Length - 1; i++)
      {
        for (int j = i + 1; j < numbers.Length; j++)
        {
          if (numbers[i] > numbers[j])
          {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
          }
        }
        
      }
      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"index {i} = {numbers[i]}");
      }
    }
  }
  



  class Program
  {
    static void Main(string[] args)
    {
     
      
     
      Console.WriteLine("Enter Size");
       int n= Convert.ToInt32(Console.ReadLine());
      
      Massive1 massive1 = new Massive1(n);
      massive1.N = n;
      massive1.MassSet();
      
      Console.WriteLine("Sorted Array");
      massive1.MassSort();

      Console.WriteLine("Enter scalar");
      int scalar = Convert.ToInt32(Console.ReadLine());
      massive1.Scalar = scalar;
      

    }
  }
}
