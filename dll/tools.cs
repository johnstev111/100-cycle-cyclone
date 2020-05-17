using System;

namespace CycloneTools{
    namespace Toolkit {
        public class MainTools {
            public static void ColouWrite(bool slow, string text, ConsoleColor col) {
                Console.ForegroundColor = col;
                if (slow) {
                    foreach (char letter in text) {
                        Console.Write(letter);
                        System.Threading.Thread.Sleep(95);
                    }
                    Console.WriteLine();
                } else {
                    Console.WriteLine(text);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}