using System;
using System.Runtime.InteropServices;
using CycloneTools.Toolkit;

namespace Cyclone {
  public class Tornado {
    StormData name;
    public Tornado(){
      name = MainTools.Case();
    }
    public sbyte Health{
      get => name.Health;
      set => name.Health = value; // Passthrough
    }
    public sbyte Damage{
      get => name.Damage;
      set => name.Damage = value;
    }
    public string Name{
        get => name.Name;
    }
    public string Desc{
        get => name.Desc;
    }
    public string Storm{
      get {
        if (this.Health > 90) {
          return @"--_-_-_-_---
   -_-_-_
    -_-_-
     -__-
    _-_
   _-
   -_
    _-_"; } else {
      return @"===----===
  ++++++
   ----
    ===
     --
    ++
   +";
        }
      }
    }
    public override string ToString() => $"Cyclone {this.Name}";
  }
}
\