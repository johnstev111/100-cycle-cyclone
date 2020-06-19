using System;
using Toolkit;
// Hello. This took me a lot of effort to write. I hope you like it!
namespace Cyclone {
  class Hundred {
    public static void Main(string[] args) {
      Console.Clear();
      MainTools.ColouWrite(true, "Welcome to the Hundred Cycle Cyclone!", ConsoleColor.Yellow);
      System.Threading.Thread.Sleep(576);
      MainTools.ColouWrite(true, "The game where you have to defeat incoming cyclones, and stop them wreaking havoc!", ConsoleColor.DarkCyan);
      byte cq = 0;
      while (true) {
        if (cq>=1) { MainTools.ColouWrite(true, "You have recovered to full health. The locals have given you some new tools.", ConsoleColor.Yellow); }
        cq += Convert.ToByte(1);
        Tornado main = new Tornado();
        Player You = new Player(main, cq);
        You.Fight();
        MainTools.ColouWrite(true, "Would you like to fight another cyclone? (y/n)", ConsoleColor.DarkYellow);
        string there = Console.ReadLine();
        if (there=="n") { End(); }
        else if (there=="N") { End(); }
        else if (there=="no") { End(); }
        else { Console.Clear(); continue; }
      }
    }
    public static void End() {
      string[] gifts = {"compass", "paper aeroplane", "cabbage", "telescope", "gold bar", "token", "fountain pen", "bottle of sand", "piece of coal", "large almond", "vanilla biscuit", "can of air", "sacred matchbox"};
      string gift = gifts[new Random().Next(0, gifts.Length)];
      MainTools.ColouWrite(true, $"Thank you for helping the locals. They give you gifts, such as a {gift}!", ConsoleColor.DarkYellow);
      Environment.Exit(0);
    }
  }
}
