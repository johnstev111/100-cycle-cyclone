using System;
// Be warned: THIS FILE IS FULL OF BAD CODE. Please be prepared to facepalm.

namespace Toolkit {
  public class MainTools {
    public static void ColouWrite(bool slow, string text, ConsoleColor col) {
      Console.ForegroundColor = col;
      if (slow) {
        foreach (char letter in text) {
          Console.Write(letter);
          System.Threading.Thread.Sleep(95);
        } Console.WriteLine();
      } else { Console.WriteLine(text); }
      Console.ForegroundColor = ConsoleColor.White;
    }
    public static StormData Case(){
      StormData torn;
      byte fire = (byte) (new Random().Next(18));
      switch (fire)
      {
        case 0:
          torn = new StormData("Dorra", "So powerful you can’t see it coming. So powerful you don’t even know about it.", 127);
          break;
        case 1:
          torn = new StormData("SuperSlimy", "Goop?", 42);
          break;
        case 2:
          torn = new StormData("ImplausibleSantaClaus", "This one blows your presents away at Christmas.", 85);
          break;
        case 3:
          torn = new StormData("Volcano", "Pompeii met a Cyclone.", 108);
          break;
        case 4:
          torn = new StormData("Poop", "Manure! I hate manure!", 30);
          break;
        case 5:
          torn = new StormData("Sharknado", "Beware! Shark is Death!", 99);
          break;
        case 6:
          torn = new StormData("AgentSquidnado", "It's dynamic.", 91);
          break;
        case 7:
          torn = new StormData("Sourkraut", "I wouldn't eat this if I were you.", 64);
          break;
        case 8:
          torn = new StormData("Celery", "Just stop with the vegetables!", 13);
          break;
        case 9:
          torn = new StormData("Firefish", "The spinning whirl of fury.", 111);
          break;
        case 10:
          torn = new StormData("Obsidian", "Whacks you in the face with rocks.", 58);
          break;
        case 11:
          torn = new StormData("Sand", "Silica in your eyes and silica in your mouth.", 102);
          break;
        case 12:
          torn = new StormData("Mud", "How dirty can you get? We hope not.", 82);
          break;
        case 13:
          torn = new StormData("Dwarf", "Throws dwarves everywhere, very dangerous to us!", 118);
          break;
        case 14:
          torn = new StormData("Pork Chop", "Er... Oink?", 49);
          break;
        case 15:
          torn = new StormData("Loudspeaker", "This one blares your least favorite music at high volume at night.", 77);
          break;
        case 16:
          torn = new StormData("Elastic Band", "This one is quite flexible!", 45);
          break;
        case 17:
          torn = new StormData("Tin", "Exactly what it says on the tin.", 54);
          break;
        default:
          throw new IndexOutOfRangeException("Incorrect number in variable fire. How did we get here?");
      }
      return torn;
    }
  }
  public struct StormData {
    public string Name { get; }
    public string Desc { get; }
    public sbyte Health { get; set; }
    public sbyte Damage { get; set; }
    public StormData(string name, string desc, sbyte health) {
      Name = name;
      Desc = desc;
      Health = health;
      if (Health>=0){
        Damage = Convert.ToSByte(4 * Math.Ceiling(Math.Sqrt(Math.Abs(Health))));
      } else {
        Damage = Convert.ToSByte(0 - (4 * Math.Ceiling(Math.Sqrt(Math.Abs(Health)))));
      }
    }
  }
}
