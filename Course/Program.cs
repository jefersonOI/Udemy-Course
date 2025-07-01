using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto oProduto = new Produto("TV", 500.00, 20);

            Console.WriteLine(oProduto.Nome);

            oProduto.Nome = "T";

            Console.WriteLine(oProduto.Nome);
        }
    }
}