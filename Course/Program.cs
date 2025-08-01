using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(10, 20);
            int s2 = Calculadora.Soma(10, 20,50,60);
            int s3 = Calculadora.Soma(10, 20,80,90,65,7652);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}