using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_min_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C: \Users\HP\Downloads\far2.0\PT\lab2_min_prime_number\lab2_min_prime_number\lb2", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream ffs = new FileStream(@"C: \Users\HP\Downloads\far2.0\PT\lab2_min_prime_number\lab2_min_prime_number\lab2", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader a = new StreamReader(fs);
            StreamReader b = new StreamReader(ffs);
            int cnt = 0;
            int min = 0;
            bool flag = false;
            string[] s = Console.ReadLine().Split();

            foreach (string h in s)
            {
                int number = int.Parse(h);
                cnt = 0;
                for (int i = 2; i <= number; i++)
                {


                    if (number % i == 0)
                    {
                        cnt++;
                    }
                    if (cnt >= 2)
                    {
                        break;

                    }
                }
                if (cnt == 1)
                {
                    if (!flag)
                    {
                        min = number;
                    }
                    if (min > number)

                        min = number;
                }
            }
            Console.WriteLine(min);
            b.WriteLine(min);
            a.Close();
            b.Close();
            fs.Close();
            ffs.Close();
            Console.ReadKey();
        }
    }
}
