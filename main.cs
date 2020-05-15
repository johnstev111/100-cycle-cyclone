using System;

namespace Cyclone {
  class Fifty {
    public static void Main (string[] args) {
      Random rand = new Random();
      int index = rand.Next(0, 7);
      Cyclone.Fifty.ColouWrite(true, "Welcome to the Fifty Cycle Cyclone!", ConsoleColor.Yellow);
      Tornado Poop = new Tornado(index);
      Console.WriteLine(Poop.Name + " - " + Poop.Type);
      Console.WriteLine(Poop.Storm);
    }
    
    private static void ColouWrite(bool slow, string text, ConsoleColor col) {
      Console.ForegroundColor = col;
      if (slow) {
        foreach (char letter in text) {
          Console.Write(letter);
          System.Threading.Thread.Sleep(141);
        }
        Console.WriteLine();
      } else {
        Console.WriteLine(text);
      }
    }

  }
}