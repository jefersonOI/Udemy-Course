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
            Console.WriteLine("Entre com o valor da cotação do dolar hoje: ");            
            double valorDolarCotacao = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o valor de dolares que será comprado: ");
            double valorAComprar = double.Parse(Console.ReadLine());          


            Console.WriteLine("Com a cotação do dolar esta sendo comprado por: " + ConversorDeMoeda.CustoDolar(valorDolarCotacao, valorAComprar).ToString("C2"));
        }
    }
}
