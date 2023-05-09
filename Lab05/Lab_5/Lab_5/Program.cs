using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_5;

class Program
{

    static void Main(string[] args)
    {
        Computer comp = new Computer("IBM", 2048);
        comp.Start();
        comp.End();

        Notebook nb = new Notebook("Asus", 1024, 120);
        nb.Start(); nb.End();

        Computer Comp2 = new Notebook("Del", 4096, 30);
        Comp2.Start(); Comp2.End();

        Netbook net = new Netbook("aboba", 2024, 90, 40);
        net.Start(); net.End();

        Notebook netb = new Netbook("AbObA", 4096, 70, 10);
        netb.Start(); netb.End();

        Console.ReadKey();
    }
}
