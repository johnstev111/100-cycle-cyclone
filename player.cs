using System;
using System.Runtime.InteropServices;
using CycloneTools.Toolkit;

namespace Cyclone {
    class Player {
        [DllImport("tools.dll", CharSet = CharSet.Unicode)]
        public static extern void ColouWrite(bool slow, string text, ConsoleColor col);
        public sbyte Health { get; set; }
        public sbyte Damage { get; set; }
        public sbyte Defence { get; set; }
        Tornado enemy;
        byte count;
        public Player(Tornado torn, byte cq){
            enemy = torn;
            count = cq;
            Health = 100;
            Damage = 20;
            Defence = Convert.ToSByte(torn.Damage - this.Damage);
        }
        public void Fight() {
            MainTools.ColouWrite(true, "DEBUG: DEBUG: DEBUG", ConsoleColor.Magenta);
        }

    }
}