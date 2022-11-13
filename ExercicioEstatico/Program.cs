using System;
using System.Globalization;

namespace ExercicioEstatico
{

    class program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2" , CultureInfo.InvariantCulture));

        }
    }
}
