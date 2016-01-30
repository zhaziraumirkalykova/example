using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // fucfion for checking the prime numbers
    static bool Prime_number(string s)
    {
        int x = int.Parse(s); // change from string to integer
        int cnt = 0;
        for (int i = 2; i <= Math.Sqrt(x); ++i) //подсчет количество делителей отличных от 1 и самого числа
        {
            if (x % i == 0) // если число делится на какоеөлибо число кроме 1 и самого числа
            {
                cnt++; // прибовляет +1
            }
        }

        return cnt == 0 && x != 1; //
    }
}