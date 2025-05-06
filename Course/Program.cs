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
            Console.Write("Quantos numeros inteiros vocês quer digitar? ");
            int quantidade = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write("Valor# " + i + ":");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Total: " + soma);

        }
    }
}
