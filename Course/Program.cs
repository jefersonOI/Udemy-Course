﻿using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            
            if (x.HasValue)
                Console.WriteLine(x.HasValue);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.HasValue);
            else
                Console.WriteLine("Y is null");

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);



        }
    }
}