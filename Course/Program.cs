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
            Produto oProduto = new Produto();

            Console.WriteLine("Entre com os dados do Produto");
            Console.Write("Nome: ");
            oProduto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            oProduto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            oProduto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + oProduto);
            Console.WriteLine();

            #region Adicionando
            Console.Write("Digite o número de produtos que será adiconado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            oProduto.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados do produto atualizado: " + oProduto);
            #endregion

            #region Removendo
            Console.WriteLine();
            Console.Write("Digite o número de produtos que será removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            oProduto.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados do produto atualizado: " + oProduto);
            #endregion
        }
    }
}
