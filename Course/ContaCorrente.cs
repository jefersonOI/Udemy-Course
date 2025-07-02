using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class ContaCorrente
    {
        public static double TaxaDoSaque = 5.0;

        public int NumeroDaConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoContaCorrente { get; private set; }

        public ContaCorrente(int numeroDaConta, string nomeTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
        }

        public ContaCorrente(int numeroDaConta, string nomeTitular, double depositoInicial) : this(numeroDaConta, nomeTitular)
        {
            RealizarDepositdo(depositoInicial);
        }

        public void RealizarDepositdo(double valorDeposito)
        {
            SaldoContaCorrente += valorDeposito;
        }

        public void RealizarSaque(double valorSaque)
        {
            SaldoContaCorrente -= valorSaque + TaxaDoSaque;
        }

        public override string ToString()
        {
            return "Conta " + NumeroDaConta + ", Titular: " + NomeTitular + ", Saldo " + SaldoContaCorrente.ToString("C2");
        }
    }
}
