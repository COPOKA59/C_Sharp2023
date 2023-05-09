using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5_two
{
    public class Avto : Transport
    {
        public Avto()
        {}

        public Avto(string mode, int speed, int mas) :base(mode, speed, mas)
        {
            
        }

        public override void Start()
        {
            Console.WriteLine("     ...ЖЖЖЖЖ...", Model);
        }
    }
}