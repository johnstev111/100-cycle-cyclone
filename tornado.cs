using System;
using CycloneTools.Toolkit;

namespace Cyclone {
  public class Tornado {
    byte index;
    public StormData[] names = new StormData[9];
    public Tornado(){
      names[0] = new StormData("Dorra", "So powerful you can’t see it coming. So powerful you don’t even know about it.", 127);
      names[1] = new StormData("SuperSlimy", "Goop?", 42);
      names[2] = new StormData("ImplausibleSantaClaus", "This one blows your presents away at Christmas.", 85);
      names[3] = new StormData("Volcano", "Pompeii met a Cyclone.", 111);
      names[4] = new StormData("Poop", "Manure! I hate manure!", 30);
      names[5] = new StormData("Sharknado", "Beware! Shark is Death!", 99);
      names[6] = new StormData("AgentSquidnado", "It's dynamic.", 91);
      names[7] = new StormData("Sourkraut", "I wouldn't eat this if I were you.", 64);
      names[8] = new StormData("Celery", "Just stop with the vegetables!", 13);
      index = Convert.ToByte(new Random().Next(0, names.Length));
    }
    public sbyte Health{
      get => names[index].Health;
      set => names[index].Health = value; // Passthrough
    }
    public string Name{
        get => names[index].Name;
    }
    public string Type{
        get => names[index].Desc;
    }
    public string Storm{
      get => @"——_—_—_—_———
   —_—_—_
    —_—_—
     —__—
    _—_
   _—
   —_
    _—_";
    }
    public override string ToString() { return $"Cyclone {this.Name}"; }
    }
}                                            