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
            Aluno oAluno = new Aluno();            

            Console.WriteLine("Entre com os dados do Aluno");
            Console.Write("Nome: ");
            oAluno.Nome = Console.ReadLine();
            
            
            Console.Write("Primeira Nota: ");
            oAluno.Nota1 = Double.Parse(Console.ReadLine());
            Console.Write("Segunda Nota: ");
            oAluno.Nota2 = Double.Parse(Console.ReadLine());
            Console.Write("Terceira Nota: ");
            oAluno.Nota3 = Double.Parse(Console.ReadLine());


            Console.WriteLine("Nota Final: " + oAluno.CalcularNotaFinal().ToString("F2"));

            if (oAluno.AprovadoOuReprovado())
                Console.WriteLine("APROVADO");
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram " + oAluno.CalcularNotaFaltante().ToString("F2") + " Pontos");
            }
        }
    }
}
