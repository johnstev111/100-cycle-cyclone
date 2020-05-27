using System;
using System.Runtime.InteropServices;
using CycloneTools.Toolkit;

namespace Cyclone {
  class Fifty {
    public static void Main(string[] args) {
      MainTools.ColouWrite(true, "Welcome to the Fifty Cycle Cyclone!", ConsoleColor.Yellow);
      System.Threading.Thread.Sleep(576);
      MainTools.ColouWrite(true, "The game where you have to defeat incoming cyclones, and stop them wreaking havoc!", ConsoleColor.DarkCyan);
      byte cq = 0;
      while (true) {
        cq += Convert.ToByte(1);
        Tornado main = new Tornado();
        Player You = new Player(main, cq);
        //Console.WriteLine(main.Name + " - " + main.Desc);
        //Console.WriteLine(main.Storm); << DEBUG
        You.Fight();
        MainTools.ColouWrite(true, "Would you like to fight another cyclone? (y/n)", ConsoleColor.DarkYellow);
        string there = Console.ReadLine();
        if (there=="n") { break; }
        else if (there=="N") { break; }
        else if (there=="no") { break; }
        else { Console.Clear(); continue; }
      }
    }
  }
}