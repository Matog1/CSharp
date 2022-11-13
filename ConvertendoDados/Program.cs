using System;

namespace ConvertendoDados
{

    class Program
    {

        static void Main(string[] args)
        {
            int meuInteiro = 10;
            double meuDouble = 5.25;
            bool meuBool = true;

            Console.WriteLine(Convert.ToString(meuInteiro));
            Console.WriteLine(Convert.ToDouble(meuInteiro));
            Console.WriteLine(Convert.ToInt32(meuDouble));

            Console.Write("teste");
            Console.WriteLine("novo conteúdo");
        }
    }
}
