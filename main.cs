using System;
using System.Runtime.InteropServices;
using CycloneTools.Toolkit;

namespace Cyclone {
  class Fifty {
    [DllImport("tools.dll", CharSet = CharSet.Unicode)]
    public static extern void ColouWrite(bool slow, string text, ConsoleColor col);
    public static void Main(string[] args) {
      MainTools.ColouWrite(true, "Welcome to the Fifty Cycle Cyclone!", ConsoleColor.Yellow);
      System.Threading.Thread.Sleep(576);
      MainTools.ColouWrite(true, "The game where you have to defeat incoming cyclones, and stop them wreaking havoc!", ConsoleColor.DarkCyan);
      Tornado First = new Tornado();
      Console.WriteLine(First.Name + " - " + First.Type);
      Console.WriteLine(First.Storm);
      Console.WriteLine(First.Health);
      First.Health -= 50;
      Console.WriteLine(First.Health);
    }
  }
}