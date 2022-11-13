using System;
using System.Globalization;

namespace Retangulo
{

    class program
    {

        static void Main(String[] args)
        {
            DiagPerim p = new DiagPerim();

            Console.WriteLine("entre com a altura e a largura de um retângulo: ");

            Console.WriteLine("altura: ");
            p.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("base: ");
            p.H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área: ");
            Console.WriteLine(p.CalcularArea());

            Console.WriteLine("Perímetro: ");
            Console.WriteLine(p.CalcularPerimetro());

            Console.WriteLine("Diagonal: ");
            Console.WriteLine(p.CalcularDiagonal());
        }
    }
}