using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora oCalculadora = new Calculadora();

            Console.WriteLine("Entre com o valor do raio");            
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = oCalculadora.Circunferencia(raio);
            double volume = oCalculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + oCalculadora.PI.ToString("F2"));
        }
    }
}
