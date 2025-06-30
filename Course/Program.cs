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
            Retangulo oRetangulo = new Retangulo();

            Console.WriteLine("Entre com os dados do Retangulo");
            Console.Write("Largura: ");
            oRetangulo.Largura = Double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            oRetangulo.Altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + oRetangulo.CalcularArea().ToString("F2"));
            Console.WriteLine("Perimetro: " + oRetangulo.CalcularPerimetro().ToString("F2"));
            Console.WriteLine("Diagonal: " + oRetangulo.CalcularDiagonal().ToString("F2"));
        }
    }
}
