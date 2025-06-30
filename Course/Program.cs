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
            Funcionario oFuncionario = new Funcionario();
            double porcentagem;


            Console.WriteLine("Entre com os dados do Funcionario");
            Console.Write("Nome: ");
            oFuncionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            oFuncionario.SalarioBruto = Double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            oFuncionario.Imposto = Double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + oFuncionario);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            porcentagem = double.Parse(Console.ReadLine());


            oFuncionario.AumentarSalario(porcentagem);
            Console.WriteLine("Dados Atualizados: " + oFuncionario);
        }
    }
}
