/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
1
-------------------
Write an application named **SumFiveInts** that allows the user to enter five 
integers and displays their sum.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace _1_SumFiveInts
{
    class SumFiveInts
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#1 - Patrick Barnes");
            WriteLine("SumFiveInts");
            int itr = 0;
            const int COUNT = 5;
            int sum = 0;
            while (itr < COUNT)
            {
                Write("Enter number {0}/{1}:", itr + 1, COUNT);
                sum += int.Parse(ReadLine());
                itr++;
            }
            WriteLine("Sum:{0}", sum);

            WriteLine("--End--");
        }
    }
}
