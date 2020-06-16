using System;
using Toolkit;
using System.Collections;

namespace Cyclone {
  public class Player {
    private byte Option { get; set; }
    private byte Item { get; set; }
    public sbyte Health { get; set; }
    public sbyte Defence { get; set; }
    Tornado torn;
    byte cq;
    private static string[] items = {"Cabbage", "Sulphuric acid", "Generator", "God's Mirror", "Sharpened Sword", "Lightning Bolt"};
    public Player(Tornado enemy, byte count){
      torn = enemy;
      cq = count; // countq: used as an iterator in loops
      Defence = Convert.ToSByte(Math.Ceiling(Convert.ToDouble(torn.Damage)/3));
    }
    public void Hurt(int health){ if ((Convert.ToInt32(this.Health) - health)<-127) { this.Health = Convert.ToSByte(-127); } else { this.Health -= Convert.ToSByte(health); } }
    private void Menu() {
      while (true) {
        System.Threading.Thread.Sleep(1414);
        Console.Clear();
        MainTools.ColouWrite(false, $"{torn.Storm}", ConsoleColor.Gray);
        MainTools.ColouWrite(false, $"{torn.Name}, {torn.Health} HP, {torn.Damage} Potential Danger\nYour Health: {this.Health}, Your Defence: {this.Defence}", ConsoleColor.DarkYellow);
        byte chance = Convert.ToByte(new Random().Next(0, 5));
        MainTools.ColouWrite(false, "[1] Fight\n[2] Seek help\n[3] Go underground or run away", ConsoleColor.Cyan);
        try { this.Option = Convert.ToByte(Console.ReadLine()); }
        catch { MainTools.ColouWrite(false, "Please input a number.", ConsoleColor.DarkYellow); continue; }
        switch (this.Option)
        {
          case 1:
            Chooser();
            break;
          case 3:
            if (chance!=1) {
              MainTools.ColouWrite(true, $"You got blown away by the {torn.Name} Cyclone! The locals had faith in you.", ConsoleColor.Red);
              Environment.Exit(1);
            } else { MainTools.ColouWrite(true, "You managed to survive! You should be proud.", ConsoleColor.Cyan); return; }
            break;
          case 2:
            if (chance!=1) {
              MainTools.ColouWrite(true, "What a waste of time. There are no locals nearby, and the cyclone is approaching you faster than ever before.", ConsoleColor.DarkYellow);
              torn.Add(10);
            } else { MainTools.ColouWrite(true, "You found help! Oh wait, it's a fish bowl.", ConsoleColor.DarkYellow); }
            break;
           default:
            MainTools.ColouWrite(false, "Please input 1, 2, or 3.", ConsoleColor.DarkYellow);
            break;
        }
        this.Hurt(Convert.ToSByte(torn.Damage-this.Defence));
        if (torn.Health<=0) { MainTools.ColouWrite(true, $"You defeated the {torn.Name} Cyclone! The locals are praising you.", ConsoleColor.DarkYellow); return; }
        else if (this.Health<=0) { MainTools.ColouWrite(true, $"You died to the {torn.Name} Cyclone! The locals had faith in you.", ConsoleColor.Red); Environment.Exit(1); }       
      }
    }
    private void Chooser() {
        ArrayList avail = new ArrayList();
        if ((cq%1)==0) { avail.Add(items[0]); avail.Add(items[1]); }
        if ((cq%3)==0) { avail.Add(items[2]); }
        if ((cq%4)==0) { avail.Add(items[5]); }
        if ((cq%5)==0) { avail.Add(items[4]); }
        if ((cq%6)==0) { avail.Add(items[3]); }
        // terrible code... but have a look in tools.cs and you'll find worse
        while (true) {
            bool leave = false; 
            byte i = 0;
            foreach (string thing in avail) { i++; MainTools.ColouWrite(false, $"[{i}] {thing}", ConsoleColor.DarkYellow); }
            try { this.Item = Convert.ToByte(Console.ReadLine()); }
            catch { MainTools.ColouWrite(false, "Please input a number.", ConsoleColor.DarkYellow); continue; }
            finally {
              if (Item>avail.Count) { MainTools.ColouWrite(false, $"Please input a number between 1 and {avail.Count}.", ConsoleColor.DarkYellow); }
              else if (Item<1) { MainTools.ColouWrite(false, $"Please input a number between 1 and {avail.Count}.", ConsoleColor.DarkYellow); } else {
              string chosen = avail[Item-1].ToString();
              if (chosen==items[0]) {
                MainTools.ColouWrite(true, "You really thought that a cabbage'd do something didn't you. But no.", ConsoleColor.Green); leave = true;
              } else if (chosen==items[1]) {
                MainTools.ColouWrite(true, "The acid made the cyclone weaker! But it's way too corrosive...", ConsoleColor.Green);
                torn.Kill(20); leave = true;
              } else if (chosen==items[2]) {
                MainTools.ColouWrite(true, "Oof. That generator ended up sparking the cyclone so much, it's now weaker!", ConsoleColor.Green);
                torn.Kill((torn.Health)/2); leave = true;
              } else if (chosen==items[3]) {
                MainTools.ColouWrite(true, $"No wonder it's called {items[3]}! It reflected the tornado, and damaged it!", ConsoleColor.Green);
                torn.Kill(((torn.Health)*2)-20); leave = true;
              } else if (chosen==items[5]) {
                MainTools.ColouWrite(true, $"The {items[4]}! The WORSTENER OF STORMS.", ConsoleColor.Green);
                torn.Add(40); leave = true;
              } else if (chosen==items[4]) {
                MainTools.ColouWrite(true, "So sharp and pointy, you are a legend!", ConsoleColor.Green);
                torn.Kill(60); leave = true;
              } else {
                throw new IndexOutOfRangeException("Ughhh. You ran out of numbers. How did we get here?");
              }
            }
          }
          if (leave) { break; }
        }            
        return;
    }
    public void Fight() {
      Health = 127;
      MainTools.ColouWrite(false, $"{torn.Storm}", ConsoleColor.Gray);
      MainTools.ColouWrite(true, $"You are fighting the mighty {torn.Name} Cyclone. Some locals have given you the following message: \n\"{torn.Desc}\"", ConsoleColor.DarkYellow);
      Menu();
    }
  }
}
