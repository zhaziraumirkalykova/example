using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(); // ввод числа   
            for (int i = 0; i < token.Length; i++)
            {
                int cnt = 0; // считат каличество делителе заданного числа
                int s = int.Parse(token[i]); // change the type from string to integer
                for (int j = 1; j <= s; j++) // число от 1 до заданного числа
                {
                    if (s % j == 0) // если заданное число делится на что либо
                    {
                        cnt++; // плюсуем 1
                    }
                }
                if (cnt < 3) // если число делителей меньше 3, то есть делители на 1 и на заданнное число)
                    {
                    Console.Write("{0} ", s); // выводим это число, как простое                    
                    }
            }
            Console.ReadKey();
        }
    }
}
