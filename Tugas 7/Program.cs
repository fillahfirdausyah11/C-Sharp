using System;

namespace Wayang {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Duryodana duryodana = new Duryodana();
            Dursasana dursasana = new Dursasana();
            Karna karna = new Karna();
            Bima bima = new Bima();
            duryodana.hit();
            dursasana.kick();
            karna.defend();
            bima.dead();
        }
    }
}
