/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
5
---
Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an 
application named **HomeSales** that prompts the user for a salesperson initial 
(*D*, *E*, or *F*). Either uppercase or lowercase initials are valid. While the user 
does not type *Z*, continue by prompting for the amount of a sale. Issue an error 
message for any invalid initials entered. Keep a running total of the amounts sold 
by each salesperson. After the user types *Z* or *z* for an initial, display each 
salesperson’s total, a grand total for all sales, and the name of the salesperson with 
the highest total.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace _5_HomeSales
{
    class HomeSales
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#5 - Patrick Barnes");
            WriteLine("HomeSales");
            int dCount = 0;
            int eCount = 0;
            int fCount = 0;
            double dSum = 0;
            double eSum = 0;
            double fSum = 0;
            
            char in_who = 'n';

            WriteLine("---Enter Z to stop---");

            while (in_who != 'Z')
            {
                Write("Who? (D,E,F) :");
                in_who = char.ToUpper(ReadLine()[0]);

                switch (in_who)
                {
                    case 'D':
                        Write("(Danielle) Enter Sale:");
                        dSum += double.Parse(ReadLine());
                        dCount++;
                        break;
                    case 'E':
                        Write("(Edward) Enter Sale:");
                        eSum += double.Parse(ReadLine());
                        eCount++;
                        break;
                    case 'F':
                        Write("(Francis) Enter Sale:");
                        fSum += double.Parse(ReadLine());
                        fCount++;
                        break;
                    case 'Z':
                        //quit
                        break;
                    default:
                        WriteLine("Error");
                        break;
                }
            }
            WriteLine("Danielle Total:{0}", dSum);
            WriteLine("Edward   Total:{0}", eSum);
            WriteLine("Francis  Total:{0}", fSum);
            WriteLine("Grand    Total:{0}", dSum+eSum+fSum);
            if (dSum > eSum)
            {
                if (dSum > fSum)
                    WriteLine("Danielle sold the most!");
                else
                    WriteLine("Francis sold the most!");
            }
            else if (eSum > fSum)
                WriteLine("Edward sold the most");

            WriteLine("--End--");
        }
    }
}
