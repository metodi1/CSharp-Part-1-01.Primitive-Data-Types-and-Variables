﻿using System;
using System.Text;
//ite a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//
//  © ©
//
// ©   ©
//
//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need
//to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

class Program
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '©';
        Console.WriteLine("  {0}\n {1}{2}{3}\n{4}{5}{6}{7}{8}\n",
            symbol, symbol, symbol, symbol, symbol, symbol, symbol, symbol, symbol);
    }


}




