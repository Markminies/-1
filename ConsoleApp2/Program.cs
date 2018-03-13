using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika1
{
    class kvit
    {
        public int nomer { get; set; }

        private String data;
        public int data1 { get; set; }

        public double Summa { get; set; }

        public kvit()
        {
            this.nomer = 0;
            this.data1 = 0;
            this.Summa = 0;
        }

        public void Input()
        {
            Console.Write("Введите номер квитанции: "); this.nomer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату квитанции: "); this.data1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сумму квитанции: "); this.Summa = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Номер: { this.nomer }");
            Console.WriteLine($"Дата: { this.data }");
            Console.WriteLine($"Сумма : { this.Summa }");
        }


    }
}
