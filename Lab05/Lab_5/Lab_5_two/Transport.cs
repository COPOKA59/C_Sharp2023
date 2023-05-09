using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5_two
{
    public class Transport
    {
        private int speed;
        private string model;
        private int mas;

        public Transport()
        {}

        public Transport(string model, int speed, int mas)
        {
            this.Model = model;
            this.speed = speed;
            this.mas = mas;
        }

        public int Mas
        {
            get { return mas; }
            set { mas = (value < 0) ? value : 0; }
        }

        public string Model
        {
            get { return model; }
            set { model = (value != "") ? value : "NoName"; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed= (value < 0) ? value : 0; }
        }

        public virtual void Start()
        {
            Console.WriteLine("  {0} стартует", Model);
        }

        public void Stop()
        {
            Console.WriteLine("  {0} останавливается\n", Model);
        }

        public void ShowInfo()
        {
            Console.WriteLine("  Модель: {0}, масса: {1}, скорость: {2}", Model, Mas, Speed);
        }
    }
}