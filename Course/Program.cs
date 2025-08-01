using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] oAluno = new Aluno[10];

            Console.WriteLine("Quantos quartos vai ser alugado");
            int qtdQuartos = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < qtdQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                oAluno[numeroQuarto] = new Aluno(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0;i < 10;i++)
            {
                if (oAluno[i] != null)
                    Console.WriteLine(i + ": " + oAluno[i]);

            }           
        }
    }
}