﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication10
{
    class Program
    {
{
        FileStream in1 = new FileStream(@"C:\Users\HP\Downloads\far2.0\PT\ConsoleApplication10\ConsoleApplication10\zhazirain.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);//create a file called zhazirain, which is used for input
        FileStream out1 = new FileStream(@"C:\Users\HP\Downloads\far2.0\PT\ConsoleApplication10\ConsoleApplication10\zhaziraout.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);//create a text file for output
        StreamReader sr = new StreamReader(in1); //read the file in
        StreamWriter sw = new StreamWriter(out1);//write into the file out
        string[] s = sr.ReadLine().Split();


        long min, max; // create the variable 
        min = long.Parse(s[0]); // change from string to number 
        max = long.Parse(s[0]); // change from string to integer
            for (int i = 1; i<s.Length; i++) // read thougth the number
            {
                long n = long.Parse(s[i]);// 
                if (min >= n)
                {
                    min = n;
                }
                if
                   (max <= n)
                {
                    max = n;
                }
            }
            Console.WriteLine("min = {0}, max={1}", min, max);
            sr.Close(); // run the program
            sw.Close();
            in1.Close();
            out1.Close();
            Console.ReadKey();

        }    }
}
