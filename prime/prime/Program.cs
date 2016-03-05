using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Token = Console.ReadLine().Split();
            for(int i=0; i<=Token.Length; i++)
            {
                int cnt = 0;
                int s;
                s=int.Parse(Token[i]);
                for (int j = 2; j<=s; j++)
                {
                    if (s % j == 0)
                    {
                        cnt++;
                    }
                }
                if ( cnt == 1)
                {
                    Console.WriteLine(s);
                } 
            }
            Console.ReadKey();
            
                     
        }
    }
}
