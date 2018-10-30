/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
4
---
Write an application named **DailyTemps** that continuously prompts a user for 
a series of daily high temperatures until the user enters a sentinel value. 
Valid temperatures range from −20 through 130 Fahrenheit. When the user enters 
a valid temperature, add it to a total; when the user enters an invalid temperature, 
display an error message. Before the program ends, display the number of temperatures 
entered and the average temperature.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace _4_DailyTemps
{
    class DailyTemps
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#4 - Patrick Barnes");
            WriteLine("DailyTemps");
            int count = 0;
            double sum = 0;
            double entry = 0;

            WriteLine("Enter 999 to stop");
            while (entry != 999)
            {
                Write("Temp {0}:", count);
                entry = double.Parse(ReadLine());
                if (entry >= -20 && entry <= 130)
                {
                    count++;
                    sum += entry;
                }
                else if (entry != 999)
                {
                    WriteLine("Error, -20 to 130 . 999 to quit.");
                }
            }
            WriteLine("Count:{0}", count);
            WriteLine("Avg  :{0}", sum / count);

            WriteLine("--End--");
        }
    }
}
