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

            //Exercicio
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            //exemplo.

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            MostrarLista();
            int tipoCombustivel = PedirTipoCombustivel();

            while (tipoCombustivel != 4)
            {
                if (tipoCombustivel == 1)
                    alcool++;
                else if (tipoCombustivel == 2)
                    gasolina++;
                else if (tipoCombustivel == 3)
                    diesel++;
                else if (tipoCombustivel < 1 || tipoCombustivel > 4)
                    Console.WriteLine("Código invalido!");

                MostrarLista();
                tipoCombustivel = PedirTipoCombustivel();
            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }

        static double Maior(double num1, double num2, double num3)
        {
            //double resultado = 0;
            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num3)
                return num2;
            else
                return num3;
        }

        static void MostrarLista()
        {
            Console.WriteLine("Segue a lista de combutiveis:");
            Console.WriteLine("1.Alcool");
            Console.WriteLine("2.Gasolina");
            Console.WriteLine("3.Diesel");
            Console.WriteLine("4.Finalizar...");
        }

        static int PedirTipoCombustivel()
        {
            try
            {
                Console.Write("Digite o numero do combustivel que você abasteceu no seu veiculo: ");
                return int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
