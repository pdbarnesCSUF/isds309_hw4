/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
8
---
Write an application named **OddNums** that displays all the odd numbers from 1 
through 99.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace _8_OddNums
{
    class OddNums
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#8 - Patrick Barnes");
            WriteLine("OddNums");

            int itr = 0;
            while (itr<100)
            {
                if (itr % 2 == 1)
                    WriteLine(itr);
                ++itr;
            }

            WriteLine("--End--");
        }
    }
}
