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
            FileStream fs = new FileStream(@"C:\Users\HP\Downloads\far2.0\PT\lab2_min_prime_number\lab2_min_prime_number\lb2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream ffs = new FileStream(@"C:\Users\HP\Downloads\far2.0\PT\lab2_min_prime_number\lab2_min_prime_number\lab2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader a = new StreamReader(fs);
            StreamWriter b = new StreamWriter(ffs);
            
            string[] token = a.ReadLine().Split();

            int min= int.Parse(token[0]);
            foreach (string w in token)
            {
                
                int x = int.Parse(w);
                bool p = false;
                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0)
                        p = true;
                }
                if (p == false && x != 1)
                {
                    if (x <= min)
                        min = x;
                }
            }
            b.WriteLine(min);
            a.Close();
            b.Close();
            fs.Close();
            ffs.Close();
            Console.ReadKey();
        }
    }
}
