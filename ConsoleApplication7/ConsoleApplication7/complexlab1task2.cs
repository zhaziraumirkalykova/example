using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Complex // создаем класс компрекс
    {
        public int a, b; // создаем комплексные числа а и б
        public Complex (int a, int b) // create conctructor 
        {
            this.a = a; // инициализирование данных
            this.b = b; //обрашение к а и б
        }
        public static Complex operator +(Complex c1, Complex c2) // перегрузка оператор + для того чтобы суммировать комлексные числа вне класса
        {
            Complex s = new Complex(c1.a + c2.a, c1.b + c2.b);
            return s; // s is the sum
        }
        public override string ToString() // change the integer number to string
        {
            return a + "/" + b; 
               
        }       
    }
        class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, w; // создание  переменнные
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            Complex first_complex = new Complex(x, y); // обращение к классу и передача переменных с1.а и с1.б
            Complex second_complex = new Complex(z, w);
            Complex s = first_complex + second_complex; // вызывание оператора +
        }
    }
}
