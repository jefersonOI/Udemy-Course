using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lstFuncionario = new List<Funcionario>();

            Console.Write("Quantos funcionários você quer registrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {   
                Console.WriteLine($"Funcionário #{i + 1}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                Funcionario oFuncionario = new Funcionario 
               {
                    FuncionarioID = id,
                    Nome = nome,
                    Salario = salario
                };

                lstFuncionario.Add(oFuncionario);                
            }

            Console.WriteLine("Passa o numero do ID do funcionário que vai receber um aumento: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionario = lstFuncionario.Find(_ => _.FuncionarioID == idFuncionario);

            if (funcionario != null)
            {
                Console.WriteLine("Entre com o valor percentual: ");
                double porcentagem = double.Parse(Console.ReadLine());

                funcionario.AumentarSalario(porcentagem);
            }

            foreach (Funcionario item in lstFuncionario)
            {
                Console.WriteLine(item);
            }
        }
    }
}