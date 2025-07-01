using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Produto
    {
        #region Propriedades e Atributos
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1) _nome = value; }
        }
       
        #endregion

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", " + Preco.ToString("C2") + ". " + Quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("C2");
        }
    }
}
