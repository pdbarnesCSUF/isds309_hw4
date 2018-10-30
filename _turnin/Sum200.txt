/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
9
---
Write an application named **Sum200** that sums the integers from 1 through 200. Display
the running total when the program is halfway complete (after the first 100 numbers), 
and at the end.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace _9_Sum200
{
    class Sum200
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#9 - Patrick Barnes");
            WriteLine("Sum200");

            int itr = 0;
            int sum = 0;
            while (itr <= 200)
            {
                sum += itr;
                if (itr >= 100)
                    Console.WriteLine(sum);
                ++itr;
            }

            WriteLine("--End--");
        }
    }
}
