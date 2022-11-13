using System;
using System.Globalization;

namespace Exercício2
{

    class program
    {

        static void Main(string[] args)
        {

            Produtos p = new Produtos();

            Console.WriteLine("digite os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);






        }
    }
}
