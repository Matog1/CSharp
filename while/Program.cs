using System;
using System.Globalization;

namespace While
{
    class program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Console.WriteLine("digite um número");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("digite outro número:");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("número inválido!");
            
        }
    }
}
