using System;
using System.Runtime.InteropServices;
using CycloneTools.Toolkit;

namespace Cyclone {
  class Fifty {
    [DllImport("tools.dll", CharSet = CharSet.Unicode)]
    public static extern void ColouWrite(bool slow, string text, ConsoleColor col);
    public static void Main(string[] args) {
      Random rand = new Random();
      byte index = Convert.ToByte(rand.Next(0, 9));
      MainTools.ColouWrite(true, "Welcome to the Fifty Cycle Cyclone!", ConsoleColor.Yellow);
      System.Threading.Thread.Sleep(576);
      MainTools.ColouWrite(true, "The game where you have to defeat incoming cyclones, and stop them wreaking havoc!", ConsoleColor.DarkCyan);
      Tornado Poop = new Tornado(index);
      Console.WriteLine(Poop.Name + " - " + Poop.Type);
      Console.WriteLine(Poop.Storm);
    }
  }
}