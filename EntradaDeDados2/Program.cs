using System;
using System.Globalization;

namespace EntradaDeDados
{

    class program
    {

        static void Main(string[]args)
        {
            ////entrada de dados mais completo.

            ////char genero = 'f';
            //int idade = 32;
            //double saldo = 10.35784;
            //string nome = "Maria";

            ////placeholder 

            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            ////interpolação

            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais!");

            ////concatenação de strings

            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais!");


            //Console.WriteLine("digite algo:");


            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();  
            //string z = Console.ReadLine();

            //string s = Console.ReadLine();

            //string[] v = s.Split(' ');
            //string a = v[0];
            //string b = v[1];
            //string c = v[2];    

            //Console.WriteLine("você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);


            //Console.Write("bom dia!");
            //Console.WriteLine("boa tarde!");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            //Console.WriteLine("digite sua idade:");

            //int n1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("você tem " + n1 + " anos");

            //ou

            Console.WriteLine("digite sua idade:");

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("você tem " + n1 + " anos");

            Console.WriteLine("agora digite uma letra:");

            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("você digitou: " + ch + "!");

            Console.WriteLine("agora um número quebrado:");

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("você digitou o número: " + (n2.ToString("F2", CultureInfo.InvariantCulture) + "!"));

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char genero = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));




        }
    }
}