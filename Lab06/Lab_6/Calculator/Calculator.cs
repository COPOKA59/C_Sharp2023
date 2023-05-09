
// Класс для подсчёта необходимых операций:
// сложение, умножение, вычисление модуля комп.числа

namespace Calculator
{
    public static class Calculator
    {
        // Операция сложения
        public static Nomber.Nomber Addition(Nomber.Nomber One, Nomber.Nomber Two)
        {
            Nomber.Nomber OneTwo = new Nomber.Nomber();
            OneTwo.a = One.a + Two.a;
            OneTwo.b = One.b + Two.b;
            return OneTwo;
        }

        // Операция умножения
        public static Nomber.Nomber Multiplication(Nomber.Nomber One, Nomber.Nomber Two)
        {
            Nomber.Nomber OneTwo = new Nomber.Nomber();
            OneTwo.a = (One.a * Two.a) - (One.b * Two.b);
            OneTwo.b = (One.a * Two.b) + (One.b * Two.a);
            return OneTwo;
        }

        // Операция вычисления модуля комп.числа
        public static double Module(Nomber.Nomber One)
        {
            return Math.Sqrt(One.a*One.a + One.b*One.b);
        }

    }
}