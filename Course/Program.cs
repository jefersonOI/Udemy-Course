using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int resultado;
            Calculadora.Triplica(a, out resultado);
            Console.WriteLine(resultado);
        }
    }
}