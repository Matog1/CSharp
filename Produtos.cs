using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício2
{
    internal class Produtos
    {

        public string nome;
        public double preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {

            return preco * Quantidade;

        }
        public void AdicionarProdutos(int quantidade){

            Quantidade += quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {

            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return nome + ", $" + preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + Quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("F2" ,
                CultureInfo.InvariantCulture); 
        }

    }
}
