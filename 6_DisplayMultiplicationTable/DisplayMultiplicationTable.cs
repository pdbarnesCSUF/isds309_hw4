/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
6
---
Write an application named **DisplayMultiplicationTable** that displays a table of the 
products of every combination of two integers from 1 through 10.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace _6_DisplayMultiplicationTable
{
    class DisplayMultiplicationTable
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#6 - Patrick Barnes");
            WriteLine("DisplayMultiplicationTable");

            for (int h = 0; h < 11; ++h)
            {
                for (int v = 0; v < 11; ++v)
                {
                    if (h == 0 && v == 0)
                        Write(" {0,3} "," ");
                    else if (h == 0 && v != 0)
                        Write(" {0,3} ", v);
                    else
                    {
                        if (v == 0)
                            Write(" {0,3} ", h);
                        else
                            Write(" {0,3} ", h * v);
                    }
                }
                WriteLine("");
            }

            WriteLine("--End--");
        }
    }
}
