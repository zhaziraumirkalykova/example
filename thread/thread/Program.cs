using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread
{
    class Program
    {
        public static void f()
        {
            Console.WriteLine(w.work);
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(f);
        }
    }
}
