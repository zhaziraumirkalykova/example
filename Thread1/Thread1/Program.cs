using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main thread started");

            Thread t = new Thread(t1);
            t.Name = "t1";
            Thread tt = new Thread(t2);
            tt.Name = "t2";
            t.Start();
            t.Join();
            tt.Start();
            tt.Join();

            Console.WriteLine("main thread finished");
            Console.ReadKey();
         }
         public static void t1()
        {
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "i");
                Thread.Sleep(200);


            }
        }
        public static void t2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "i");
                Thread.Sleep(200);


            }
        }
    }
}
