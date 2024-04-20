using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula55
{
    class Produto
    {
        //Padrão de nomes para atributos privados: _atributo
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome)) 
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarEstoque(int estoque)
        {
            _quantidade += estoque;
        }

        public void RemoverEstoque(int estoque)
        {
            _quantidade -= estoque;
        }

        public override string ToString()
        {
            return "Produto: " + _nome + ". Valor unitário R$" + _preco.ToString("F2") + ". Estoque: " + _quantidade + " unidades. Valor total em estoque: R$" + ValorTotalEstoque().ToString("F2") + ".";
        }
    }
}
