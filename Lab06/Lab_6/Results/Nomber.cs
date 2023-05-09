
// Класс для создания комплексного числа

namespace Nomber
{
    public class Nomber
    {
        // Комплексное число имеет вид: a + b*i, где a,b - числа, i - мнимая единица
        public double a;
        public double b;

        public Nomber()
        {
            this.a = 0;
            this.b = 0;
        }

        public Nomber(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Show()
        {
            Console.WriteLine("{0} + {1}i", a, b);
        }
    }
}