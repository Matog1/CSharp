using System;

namespace Strings
{

    class Program
    {

        static void Main(string[]args)
        {

            string nome = "Paula ";
            string sobrenome = "Toller";

            //Console.WriteLine(String.Concat(nome, sobrenome));
            //Console.WriteLine($"{nome}{sobrenome}");
            //Console.WriteLine(nome[0]);

            string nomeCompleto = $"{nome}{sobrenome}";
            Console.WriteLine(nomeCompleto);
            int posicao = nomeCompleto.IndexOf("T");
            //pegar o sobrenome
            string nomeFinal = nomeCompleto.Substring(posicao);
            Console.WriteLine(nomeFinal);
            Console.WriteLine(nomeFinal.ToUpper());
            Console.WriteLine(nomeFinal.ToLower());
        }
    }
}
