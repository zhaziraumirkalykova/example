using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Complex( )
        {

        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            int cnt = c1.b * c2.b;
            int sum = c2.b * c1.a + c1.b * c2.a;
            if (cnt > sum)
            {
                for (int i = sum; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = cnt; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }

                }
            }
            Complex c3 = new Complex(sum, cnt);
            return c3;
        }
        public string ans()
        {
            return a + "/" + b;
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex(1, 2);
            Complex y = new Complex(2, 3);
            Complex sum = x + y;
            Console.WriteLine(sum.ans());
            Console.ReadKey();
        }
    }
}
