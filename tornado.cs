using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclone {
  public class Tornado {
    byte index;
    public Dictionary<string, string> names = new Dictionary<string, string>();
    public Tornado(byte i){
      index = i;
      names["Dorra"] = "So powerful you can’t see it coming. So powerful you don’t even know about it.";
      names["SuperSlimy"] = "Goop?";
      names["ImplausibleSantaClaus"] = "This one blows your presents away at Christmas.";
      names["Volcano"] = "Pompeii met a Cyclone.";
      names["Poop"] = "Manure! I hate manure!";
      names["Sharknado"] = "Beware! Shark is Death!";
      names["AgentSquidnado"] = "It's dynamic.";
      names["Sourkraut"] = "I wouldn't eat this if I were you.";
      names["Celery"] = "Just stop with the vegetables!";
    }
    public string Name{
        get{
            return names.Keys.ToArray()[index]; //names[index]; // FIXME
        }
    }
    public string Type{
        get{
            return names.Values.ToArray()[index]; //desc[index]; // FIXME
        }
    }
    public string Storm{
      get{
        return @"--_-_-_-_---
   -_-_-_
    -_-_-
     -__-
    _-_
   _-
   -_
    _-_"; } // FIXME
    }
    public override string ToString() { return $"Cyclone {this.Name}"; }
    }
}