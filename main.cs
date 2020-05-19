using System;
using System.Runtime.InteropServices;
using CycloneTools.Toolkit;

namespace Cyclone {
  class Fifty {
    [DllImport("tools.dll", CharSet = CharSet.Unicode)]
    public static extern void ColouWrite(bool slow, string text, ConsoleColor col);
    [DllImport("tools.dll", CharSet = CharSet.Unicode)]
    public static extern void CycloneCheck(byte index, int count);
    public static void Main(string[] args) {
      Random rand = new Random();
      byte torn = 9;
      byte index = Convert.ToByte(rand.Next(0, torn));
      MainTools.ColouWrite(true, "Welcome to the Fifty Cycle Cyclone!", ConsoleColor.Yellow);
      System.Threading.Thread.Sleep(576);
      MainTools.ColouWrite(true, "The game where you have to defeat incoming cyclones, and stop them wreaking havoc!", ConsoleColor.DarkCyan);
      Tornado First = new Tornado(index);
      MainTools.CycloneCheck(torn, First.names.Count);
      Console.WriteLine(First.Name + " - " + First.Type);
      Console.WriteLine(First.Storm);
    }
  }
}