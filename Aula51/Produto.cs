using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula51
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Contrutores são gerados depois dos atributos e têm o mesmo nome da classe
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarEstoque(int estoque)
        {
            Quantidade += estoque;
        }

        public void RemoverEstoque(int estoque)
        {
            Quantidade -= estoque;
        }

        public override string ToString()
        {
            return "Produto: " + Nome + ". Valor unitário R$" + Preco.ToString("F2") + ". Estoque: " + Quantidade + " unidades. Valor total em estoque: R$" + ValorTotalEstoque().ToString("F2") + ".";
        }
    }
}
