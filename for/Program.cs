using System;
using System.Globalization;

namespace For
{

    class program
    {

        static void Main(string[] args)
        {

            //Console.WriteLine("quantos números inteiros você vai digitar?");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine("sua tia");
            //}

            Console.WriteLine("quantos números inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("valor {0} = " , i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("soma = " + soma);


        }
    }
}
