using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Lab_5_Publication
{
    public class Publication
    {
        // Скрытые поля
        // Издание - Name, Автор - Autor,
        // Издательство - Publishing_company, Год издания - Year
        private string Name;
        private string Autor;
        private string Publishing_company;
        private int Year;

        // Конструктор без параметров
        public Publication()
        {
            this.name = "";
            this.autor = "";
            this.publishing_company = "";
            this.year = 0;
        }

        // Конструктор с параметрами
        public Publication(string Name, string Autor, string Publishing_company, int Year)
        {
            this.name = Name;
            this.autor = Autor;
            this.publishing_company = Publishing_company;
            this.year = Year;
        }

        // Общедоступные свойства
        public string name
        {
            get { return Name; }
            set { Name = (value != "") ? value : "NoName"; }
        }

        public string autor
        {
            get { return Autor; }
            set { Autor = (value != "") ? value : "NoName"; }
        }

        public string publishing_company
        {
            get { return Publishing_company; }
            set { Publishing_company = (value != "") ? value : "NoName"; }
        }

        public int year
        {
            get { return Year; }
            set { Year = (value == 0) ? 1564 : value; }
        }

        // Общедоступные методы
        // Вывод всех полей класса
        public void Show()
        {
            Console.WriteLine("\n  Издание {0}, Автор: {1}, Издательство: {2}, Год издания: {3}", name, autor, publishing_company, year);
        }

        //  Метод, что бы изменить год издания, увеличив или уменьшив его на указанное число лет
        public void Change_year(int N)
        {
            year += N;
        }
        // Метод, что бы определить, попадает ли год издания в заданный интервал
        public void Check_year(int a, int b)
        {
            if ((year < b) && (year > a))
            {
                Console.WriteLine("\n Год попадает в указанный интервал");
            }
            else 
                Console.WriteLine("\n Год не попадает в указанный интервал");

        }
    }
}