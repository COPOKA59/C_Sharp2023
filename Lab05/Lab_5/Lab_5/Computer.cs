using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5
{
    public class Computer
    {
        // Скрытые поля
        private string model;
        private int ram;

        // Конструктор без параметров
        public Computer()
        {
        }

        // Конструктор с параметрами
        public Computer(String model, int ram)
        {
            this.Model = model;
            this.Ram = ram;
        }

        // Общедоступные свойства
        public string Model
        {
            get { return model; }
            set { model = (value != "") ? value : "NoName"; }
        }

        public int Ram
        {
            get { return ram; }
            set { ram = (value < 500) ? 640 : value; }
        }

        // Общедоступный метод End
        public virtual void End()
        {
            Console.WriteLine("{0} выключается", Model);
        }

        // Общедоступный метод Start
        public virtual void Start()
        {
            Console.WriteLine("{0} работает, память = {1}", Model, Ram);
        }
    }
}