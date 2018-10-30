/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
2
---
Write an application named **SumInts** that allows the user to enter any number of 
integers continuously until the user enters 999. Display the sum of the values 
entered, not including 999.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace SumInts
{
    class SumInts
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#2 - Patrick Barnes");
            WriteLine("SumInts");
            int count = 0;
            int entry = 0;
            int sum = 0;
            while (entry != 999) //backup check
            {
                count++;
                Write("Enter number {0}:", count);
                entry = int.Parse(ReadLine());
                if (entry == 999) break;
                sum += entry;
            }
            WriteLine("Sum:{0}", sum);

            WriteLine("--End--");
        }
    }
}
