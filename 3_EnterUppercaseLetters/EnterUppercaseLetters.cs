/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw4
*/
/*
3
---
Write an application named **EnterUppercaseLetters** that asks the user to type an 
uppercase letter from the keyboard. If the character entered is an uppercase 
letter, display *OK*; if it is not an uppercase letter, display an error message. 
The program continues until the user types an exclamation point.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace EnterUppercaseLetters
{
    class EnterUppercaseLetters
    {
        static void Main(string[] args)
        {
            WriteLine("hw4#3 - Patrick Barnes");
            WriteLine("EnterUppercaseLetters");
            char entry = '0';
            while (entry != '!')
            {
                Write("Enter uppercase letter:");
                entry = char.Parse(ReadLine());
                if (entry >= 'A' && entry <= 'Z')
                    WriteLine("*OK*");
                else
                    WriteLine("Thats not an uppercase letter");
            }

            WriteLine("--End--");
        }
    }
}
