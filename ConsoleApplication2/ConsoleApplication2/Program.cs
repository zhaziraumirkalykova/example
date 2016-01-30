using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            for (int i= 0; i<token.Length; i++)
            {
                int cnt = 0;
                int s = int.Parse(token[i]);
                for (int j=2; j<= s; j++)
                {
                    if(s % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt < 3)
                {
                    Console.Write("{0}", s);

                }
            }
            Console.ReadKey();
        }
    }
}
