using System;
using System.Globalization;

namespace teste1
{

    class program
    {

        static void Main(string[] args)
        {
             

            Console.WriteLine("entre com a operação que deseja realizar: ");

            string operacao = Console.ReadLine();

            Console.WriteLine("agora entre com o primeiro número da operação: ");

            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("entre com o segundo número da operação"); 

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             double resultado1 = n1 * n2;
             double resultado2 = n1 + n2;
             double resultado3 = n1 - n2;
             double resultado4 = n2 / n2;

            if (operacao == "multiplicação" + "multiplicacao");
            {

                Console.WriteLine("a multiplicação entre " + n1 + " e " + n2 + " é " + resultado1 + "!");

            }

            if (operacao == "soma" + "mais");
            {

                Console.WriteLine("a soma entre " + n1 + " e " + n2 + " é " + resultado2 + "!");

            }

            if (operacao == "subtracao" + "subtração") ;
            {

                Console.WriteLine("a subtração entre " + n1 + " e " + n2 + " é " + resultado3 + "!");

            }
            if(operacao == "divisão" + "divisao");
            {

                Console.WriteLine("a divisão entre " + n1 + " e " + n2 + " é " + resultado4 + "!");

            }

        }
    }
}
