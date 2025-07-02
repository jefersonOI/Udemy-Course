using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o numero da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre com o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();
            
            Console.Write("Havera deposito inicial (s/n): ");
            char comDepositoInicial = char.Parse(Console.ReadLine());
            
            ContaCorrente oContaCorrente;
            if (comDepositoInicial == 's')
            {
                Console.Write("Entre o valor para deposito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                oContaCorrente = new ContaCorrente(numeroDaConta, nomeTitular, saldoInicial);
            }
            else
                oContaCorrente = new ContaCorrente(numeroDaConta, nomeTitular);

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(oContaCorrente);
            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            oContaCorrente.RealizarDepositdo(valorDeposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(oContaCorrente);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            oContaCorrente.RealizarSaque(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(oContaCorrente);
            Console.WriteLine();
        }
    }
}