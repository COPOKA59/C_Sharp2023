using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5
{
    public class Netbook : Notebook
    {
        private double mas;

        public Netbook()
        {}

        public Netbook(string model, int ram, int time, double mas) : base(model, ram, time)
        {
            this.Mas = mas;
        }

        public double Mas
        {
            get { return mas;  }
            set { mas = (value < 3) ? 4.5 : value; }
        }

        public override void Start()
        {
            Console.WriteLine("{0} работает, память = {1}, масса = {2}", Model, Ram, Mas);
        }
    }
}