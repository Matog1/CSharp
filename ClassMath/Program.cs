using System;

namespace ClassMath
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("O máximo entre 10 e 20 é: " + Math.Max(10, 20));
            Console.WriteLine("O mínimo entre 10 e 20 é: " + Math.Min(10, 20));

            Console.WriteLine("A raíz quadrada de 64 é: " + Math.Sqrt(64));
            Console.WriteLine("O arredondamento de 9,99 é: " + Math.Round(9.99));
        }
    }
}
