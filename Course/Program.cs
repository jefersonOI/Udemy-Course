using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ////Console.Write("Quantidade no estoque: ");
            ////int quantidade = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Produto oProduto = new Produto(nome, preco);
            Produto oProduto = new Produto("TV", 500.00, 20);

            Console.WriteLine(oProduto.GetNome());

            oProduto.SetNome("T");

            Console.WriteLine(oProduto.GetNome());

            //Console.WriteLine("Dados do produto: " + oProduto);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //oProduto.AdicionarProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + oProduto);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //oProduto.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + oProduto);
        }
    }
}