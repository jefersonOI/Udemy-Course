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
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados da primeira Funcionario");
            x.Nome = Console.ReadLine();
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados da segunda Funcionario");
            y.Nome = Console.ReadLine();
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double media = (x.Salario + y.Salario) / 2;

            Console.WriteLine("A média dos 2 salário é de: " + media.ToString("C2"));
        }
    }
}
