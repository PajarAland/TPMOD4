// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using TPMOD4.Kodepos;
using TPMOD4.Kodepost;
using TPMOD4.Door;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh_1 :");
            KodePos kodepos = new KodePos();
            kodepos.setKodePos();
            kodepos.getKodePos();

            Console.WriteLine("\nContoh_2 :");
            KodePost kodepos1 = new KodePost();
            kodepos.getKodePos();

            Console.WriteLine("\nSoal 3 :");
            DoorMachine door = new DoorMachine();
            door.run();
        }
    }
}
