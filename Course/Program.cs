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
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira Pessoa");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados da segunda Pessoa");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x.Idade > y.Idade)
                Console.WriteLine("Pessoa mais velha: " + x.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " + y.Nome);
                
        }
    }
}
