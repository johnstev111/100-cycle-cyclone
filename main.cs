using System;

namespace Cyclone {
  class Fifty {
    public static void Main(string[] args) {
      Random rand = new Random();
      byte index = Convert.ToByte(rand.Next(0, 7));
      ColouWrite(true, "Welcome to the Fifty Cycle Cyclone!", ConsoleColor.Yellow);
      System.Threading.Thread.Sleep(576);
      ColouWrite(true, "The game where you have to defeat incoming cyclones, and stop them wreaking havoc!", ConsoleColor.DarkCyan);
      Tornado Poop = new Tornado(index);
      Console.WriteLine(Poop.Name + " - " + Poop.Type);
      Console.WriteLine(Poop.Storm);
    }
    
    private static void ColouWrite(bool slow, string text, ConsoleColor col) {
      Console.ForegroundColor = col;
      if (slow) {
        foreach (char letter in text) {
          Console.Write(letter);
          System.Threading.Thread.Sleep(95);
        }
        Console.WriteLine();
      } else {
        Console.WriteLine(text);
      }
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}