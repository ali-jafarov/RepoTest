using System;

namespace MusicInst
{
  interface IInstrument
  {
   const string Key = "Do Major";


    void Play();
    
  }

  public class Guitar : IInstrument
  {
    
    public int numberOfStrings = 7;

    public void Play()
    {
      Console.WriteLine($"{numberOfStrings}-струнная гитара играет {IInstrument.Key}");
    }



  }
  public class Drum : IInstrument
  {
    public string size = "Большой";

    public void Play()
    {
      Console.WriteLine($"{size} барабан играет {IInstrument.Key}");
    }

  }
  public class Trumpet : IInstrument
  {
    public int diametr = 12;

    public void Play()
    {
      Console.WriteLine($"труба с диаметром {diametr} играет {IInstrument.Key}");
    }
  }
  

  class Program
  {
    static void Main(string[] args)
    {
     

      IInstrument[] iinstruments = new IInstrument [3];
      iinstruments[0] = new Guitar();
      iinstruments[1] = new Drum();
      iinstruments[2] = new Trumpet();
      foreach (var iinstrument in iinstruments)
      {
        
        iinstrument.Play();
        
      }
    }
  }
}
