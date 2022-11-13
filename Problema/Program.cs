using System;
using System.Globalization;

namespace Problema
{

    class program
    {

        static void Main(string[]args)
        {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();


            double areaY = y.Area();

            Console.WriteLine("Área de x igual a: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y igual a: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("maior área = área X com a seguinte medida: " + areaX);
            }
            else
            {
                Console.WriteLine("maior área = área y com a seguinte medida: " + areaY);
            }



        }
    }
}
