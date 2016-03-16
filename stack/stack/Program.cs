using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stacks(@"C:\Users\HP\Downloads\far2.0\PT");
            }
            static void Stacks(string path)
        {
                Stack<string> dirs = new Stack<string>(20);// create the stack
                Console.WriteLine(path + "/" + Directory.GetFiles(path).Length);// quantity of file in the path 
                dirs.Push(path);// add the path for initual file

                while (dirs.Count > 0)// do the cycle while the stack gets 0
                {
                    string currentDir = dirs.Pop();// takes the path of the last file 
                    string[] subDirs = Directory.GetDirectories(currentDir);// into the massiv gets the files from last folder 
                    foreach (string str in subDirs)
                    {
                        Console.WriteLine(str + ": " + Directory.GetFiles(str).Length);// quantity of files in each folder
                        dirs.Push(str);//path of the files in the stack
                    }
                }
                Console.ReadKey();
            }
        }
 }
