using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Complex
    {
        public int a, b; // создание комплексного числа
        public Complex (int a, int b) // создание конструктора
        {
            this.a = a;
            this.b = b; // обрашение параметров фунций
        }
        public static Complex operator +(Complex n1, Complex n2) // создание операта плюс для того чтобы суммировать комплексные числа
        {
            Complex sum = new Complex(c1.a + c2.a, c1.b + c2.b); // суммирование числа а аи б 
            return sum; // возвращяем значение 
        }
        public override string ToSting() // to chance the integer into string
        {
            a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, w; //задаю переменные
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            Complex first_complex = new Complex(x, y);
            Complex second_complex = new Complex(x, y);
            Complex sum = first_complex + second_complex;
        }
    }
}
