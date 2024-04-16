using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Conversor
    {
        public static double Imposto = 0.06;

        public static double TotalEmReais(double cotacao, double quantidade)
        {
            double total = cotacao * quantidade;
            double totalComImposto = total + total * Imposto;

            return totalComImposto;
        }
    }
}
