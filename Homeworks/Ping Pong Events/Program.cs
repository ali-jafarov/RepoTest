using System;

namespace Ping_Pong_Events
{
  class Ping
  {
    public event MessageDelegate NotifyEvent;

    public void ReceivePong()
    {
      NotifyEvent?.Invoke();
    }
  }

  class Pong
  {
    public event MessageDelegate NotifyEvent;

    public void ReceivePing()
    {
      NotifyEvent?.Invoke();
    }
  }

  delegate void MessageDelegate();
  class Program
  {
    static void Main(string[] args)
    {
      var ping = new Ping();
      var pong = new Pong();

      ping.NotifyEvent += () => Console.WriteLine("Ping received Pong");
      pong.NotifyEvent += () => Console.WriteLine("Pong received Ping");

      for (int i = 0; i < 10; i++)
      {
        ping.ReceivePong();
        pong.ReceivePing();
      }
    }

  }
}
