using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Course
{
    class Program
    {
        static double PI = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio");            
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + PI.ToString("F2"));
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }

        static double Volume(double raio)
        {
            return 4.0/3.0 * PI * raio * raio * raio;
        }


    }
}
