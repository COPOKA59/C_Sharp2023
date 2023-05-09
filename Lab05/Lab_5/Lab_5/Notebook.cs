using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5
{
    public class Notebook : Computer
    {
        private int time;

        // Конструктор по умолчанию
        public Notebook()
        {}

        // Конструктор с параметрами
        public Notebook(string model, int ram, int time) : base(model, ram)
        {
            this.Time = time;
        }

        // Общедоступные свойства
        public int Time
        {
            get { return time; }
            set { time = (value < 10) ? 15 : value; }
        }

        // Создаём новый метод End класса - наследника с модификатором override
        public override void End()
        {
            Console.WriteLine("{0} выключается, заряд {1} мин", Model, Time);
        }
    }
}