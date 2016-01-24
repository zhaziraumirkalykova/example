using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Complex
    {
        public int a, b;
        public Complex (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static int gcd(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a < b)
                    b = b % a;
                else
                    a = a % b;
            }
            if (b > a)
                return b;
            return a;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            // 5/6+6/7-> 11/13
            Complex c3 = new Complex(c1.a + c2.a, c1.b + c2.b);
           // return g = gcd(c3.a, c3.b);
           // c3.a /= g;
           // c3.b /= g;
            return c3;   
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Console.WriteLine(c);
            Complex d = c + c;
            Console.WriteLine(d);
            Concole.ReadKey();

        }
    }
}
