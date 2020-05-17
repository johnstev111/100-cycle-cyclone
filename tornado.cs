using System;

namespace Cyclone {
  public class Tornado {
    private string[] names = {"Dorra", "SuperSlimy", "ImplausibleSantaClaus", "Volcano", "Poop", "Sharknado", "AgentSquidnado", "Sourkraut", "Celery"};
    private string[] desc = {"So powerful you can’t see it coming. So powerful you don’t even know about it.", "Goop?", "This one blows your presents away at Christmas.", "Pompeii met a Cyclone.", "Manure! I hate manure!", "Beware! Shark is Death!", "It's dynamic.", "I wouldn't eat this if I were you.", "All these cyclones are just vegetables now..."};
    byte index;
    public Tornado(byte i){
      index = i;
    }
    public string Name{
        get{
            return names[index];
        }
    }
    public string Type{
        get{
            return desc[index];
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
    _-_"; }
    }
    public override string ToString() { return $"Cyclone {this.Name}"; }
  }
}