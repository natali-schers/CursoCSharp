using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula42
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return "Produto: " + Nome + ". Valor unitário R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ". Estoque: " + Quantidade + " unidades. Valor total em estoque: R$" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture) + ".";
        }
    }
}
