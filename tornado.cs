using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclone {
  public class Tornado {
    byte index;
    public Dictionary<string, string> names = new Dictionary<string, string>();
    private sbyte[] strengths = {127, 42, 85, 111, 30, 99, 91, 64, 13};
    private sbyte currStrength;
    public Tornado(){
      names["Dorra"] = "So powerful you can’t see it coming. So powerful you don’t even know about it.";
      names["SuperSlimy"] = "Goop?";
      names["ImplausibleSantaClaus"] = "This one blows your presents away at Christmas.";
      names["Volcano"] = "Pompeii met a Cyclone.";
      names["Poop"] = "Manure! I hate manure!";
      names["Sharknado"] = "Beware! Shark is Death!";
      names["AgentSquidnado"] = "It's dynamic.";
      names["Sourkraut"] = "I wouldn't eat this if I were you.";
      names["Celery"] = "Just stop with the vegetables!";
      index = Convert.ToByte(new Random().Next(0, names.Count));
      if (names.Count != strengths.Length) {
        throw new IndexOutOfRangeException("Incorrect number of health values in strength. How did we get here?");
      }
      currStrength = strengths[index];
    }
    public sbyte Health{
      get => currStrength;
      set => currStrength = value;
    }
    public string Name{
        get => names.Keys.ToArray()[index];
    }
    public string Type{
        get => names.Values.ToArray()[index];
    }
    public string Storm{
      get => @"--_-_-_-_---
   -_-_-_
    -_-_-
     -__-
    _-_
   _-
   -_
    _-_";
    }
    public override string ToString() { return $"Cyclone {this.Name}"; }
    }
}