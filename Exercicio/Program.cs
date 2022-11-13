using System;

namespace Exercicio
{

    class program
    {

        static void Main(string[] args)
        {

            //Console.WriteLine("digite o nome:");

            //string nome = Console.ReadLine();

            //Console.WriteLine("digite a idade:");

            //int idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("digite outro nome");

            //string nome2 = Console.ReadLine();

            //Console.WriteLine("digite outra idade:");

            //int idade2 = int.Parse(Console.ReadLine());


            //if (idade > idade2)
            //{

            //    Console.WriteLine("pessoa mais velha: " + nome);

            //}

            //else
            //{

            //    Console.WriteLine("pessoa mais velha: " + nome2);


            Nome n, i;
            n = new Nome();
            i = new Nome();

            Console.WriteLine("Digite o nome:");

            n.A = Console.ReadLine();

            Console.WriteLine("Digite a idade:");

            i.B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro nome:");

            n.C = (Console.ReadLine());

            Console.WriteLine("Digite outra idade:");

            i.D = int.Parse(Console.ReadLine());

            if (i.B > i.D)
            {

                Console.WriteLine(n.A + " é a pessoa mais velha!");

            }
            else
            {

                Console.WriteLine(n.C + " é a pessoa mais velha!");

            }



           }

        }
    }

