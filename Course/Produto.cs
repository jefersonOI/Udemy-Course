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
        private double _preco;
        private int _quantidade;

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1) _nome = value; }
        }

        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
        #endregion

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", " + _preco.ToString("C2") + ". " + _quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("C2");
        }
    }
}
