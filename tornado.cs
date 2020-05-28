using System;
using CycloneTools.Toolkit;

namespace Cyclone {
  public class Tornado {
    StormData name;
    public Tornado(){ name = MainTools.Case(); }
    public sbyte Health{ get => name.Health; set => name.Health = value; }
    public sbyte Damage{ get => name.Damage; set => name.Damage = value; }
    public string Name{ get => name.Name; }
    public string Desc{ get => name.Desc; }
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
    } // Talk about bad code...
    public void Add(int health){
      if ((Convert.ToInt32(this.Health) + health)>127) {this.Health = Convert.ToSByte(127);} else {this.Health += Convert.ToSByte(health);}
      if (Health>=0){
        Damage = Convert.ToSByte(4 * Math.Ceiling(Math.Sqrt(Math.Abs(Health))));
      } else {
         Damage = Convert.ToSByte(0 - (4 * Math.Ceiling(Math.Sqrt(Math.Abs(Health)))));
      }
    }
    public void Kill(int health){
      if ((Convert.ToInt32(this.Health) - health)<-127) {this.Health = Convert.ToSByte(-127);} else {this.Health -= Convert.ToSByte(health);}
      if (Health>=0){
        Damage = Convert.ToSByte(4 * Math.Ceiling(Math.Sqrt(Math.Abs(Health))));
      } else {
        Damage = Convert.ToSByte(0 - (4 * Math.Ceiling(Math.Sqrt(Math.Abs(Health)))));
      }
    }
    public override string ToString() => $"Cyclone {this.Name}";
  }
}
