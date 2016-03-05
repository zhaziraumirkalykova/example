using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            elsereturn String.Empty;
        }private string[] names = { "Spencer", "Sally", "Doug" };
        static void Main(string[] args)
        {
             Console.ReadKey();                
        }
    }
}
