using System;

    namespace OperadoresCsharp
{
    class Program
    {

        static void Main(string[]args)
        {

            /*a = 2 a recebe 2
              a += 2 a recebe a+2
              a -= 2 a recebe a-2
              a *= 2 a recebe a*2
              a /= 2 a recebe a/2
              a %= 3 a recebe a%3*/
            //int Soma1 = 100 + 50;
            //int Soma2 = Soma1 + 250;
            //int Soma3 = Soma1 + Soma2;
            //Console.WriteLine("resultado soma1: " + Soma1);
            //Console.WriteLine("resultado soma2: " + Soma2);
            //Console.WriteLine("resultado soma3: " + Soma3);


            //int a = 10;

            //a++;

            //Console.WriteLine(a);

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8; //ou 10.0 / 8.0

            //fórmula de bhaskara :D

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);


        }
    }
}
