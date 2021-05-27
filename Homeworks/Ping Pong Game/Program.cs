using System;

namespace Ping_Pong_Game
{
  class PingPongPlayer
  {
    public string Name { get; set; }
    public int Score { get; private set; }
    public event MyDelegate HitLostEvent;
    public event MyDelegate HitHandledEvent;
    public event MyDelegate PlayerWinEvent;
    public bool IsWinner => Score == 11;

    public void Hit(int playerHit)
    {
      Random rnd = new Random();
      if (playerHit == rnd.Next(1, 3))
      {
        HitHandledEvent?.Invoke(Name);
        Score++;
      }
      else
      {
        HitLostEvent?.Invoke(Name);
      }

      if (IsWinner)
      {
        PlayerWinEvent?.Invoke(Name);
      }
    }
  }

  delegate void MyDelegate(string message);
  class Program
  {
    static void Main(string[] args)
    {
      var player1 = new PingPongPlayer();
      var player2 = new PingPongPlayer();

      player1.HitLostEvent += x => Console.WriteLine($"Игрок: {x} пропустил удар.");
      player1.HitHandledEvent += x => Console.WriteLine($"Игрок: {x} отбил удар.");
      player1.PlayerWinEvent += x => Console.WriteLine($"Игрок: {x} победил.");

      player2.HitLostEvent += x => Console.WriteLine($"Игрок: {x} пропустил удар.");
      player2.HitHandledEvent += x => Console.WriteLine($"Игрок: {x} отбил удар.");
      player2.PlayerWinEvent += x => Console.WriteLine($"Игрок: {x} победил.");

      Console.WriteLine("Введите имя первого игрока:");
      player1.Name = Console.ReadLine();

      Console.WriteLine("Введите имя второго игрока:");
      player2.Name = Console.ReadLine();

      while (true)
      {
        Console.Clear();

        Console.WriteLine($"Счет: {player1.Name} = {player1.Score}     {player2.Name} = {player2.Score}");

        Console.WriteLine($"Отбивает {player1.Name}, введите число от 1 до 3ех.");
        var hitNumber = Convert.ToInt32(Console.ReadLine());
        player1.Hit(hitNumber);

        if (player1.IsWinner)
          return;

        Console.WriteLine();

        Console.WriteLine($"Отбивает {player2.Name}, введите число от 1 до 3ех.");
        hitNumber = Convert.ToInt32(Console.ReadLine());
        player2.Hit(hitNumber);

        if (player2.IsWinner)
          return;

        Console.ReadKey();
      }
    }
  }
}
