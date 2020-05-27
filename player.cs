using System;
using System.Runtime.InteropServices;
using CycloneTools.Toolkit;

namespace Cyclone {
  public class Player {
    private byte option { get; set; }
    public sbyte Health { get; set; }
    public sbyte Damage { get; set; }
    public sbyte Defence { get; set; }
    Tornado torn;
    byte count;
    public Player(Tornado enemy, byte cq){
      torn = enemy;
      count = cq;
      Health = 100;
      Damage = 20;
      Defence = Convert.ToSByte(torn.Damage - this.Damage);
    }
    private void Menu() {
      while (true) {
        byte chance = Convert.ToByte(new Random().Next(0, 5));
        MainTools.ColouWrite(false, "[1] Fight\n[2] Go underground\n[3] Seek help", ConsoleColor.Cyan);
        try { this.option = Convert.ToByte(Console.ReadLine()); }
        catch { MainTools.ColouWrite(false, "Please input a number.", ConsoleColor.DarkYellow); continue; }
        finally {
          switch (option)
          {
            case 1:
              //Item();
              break;
            case 2:
              if (chance!=1) {
                MainTools.ColouWrite(true, $"You got blown away by the {torn.Name} Cyclone! The locals had faith in you.", ConsoleColor.Red);
                Environment.Exit(1);
              } else { MainTools.ColouWrite(true, "You managed to survive! You should be proud.", ConsoleColor.Cyan); }
              break;
            case 3:
              if (chance!=1) {
                MainTools.ColouWrite(true, "What a waste of time. There are no locals nearby, and the cyclone is approaching you faster than ever before.", ConsoleColor.DarkYellow);
              } else { MainTools.ColouWrite(true, "You found help! Oh wait, it's a fish bowl.", ConsoleColor.DarkYellow); }
              break;
            default:
              MainTools.ColouWrite(false, "Please input 1, 2, or 3.", ConsoleColor.DarkYellow);
              break;
          }
        }
      }
    }
    public void Fight() {
      MainTools.ColouWrite(false, $"{torn.Storm}", ConsoleColor.Gray);
      MainTools.ColouWrite(true, $"You are fighting the almighty {torn.Name} Cyclone. Some locals have given you the following message: \n\"{torn.Desc}\"", ConsoleColor.DarkYellow);
      Menu();
    }

  }
}
