﻿using System;
using System.Globalization;

namespace MembrosEstaticos
{

    class program
    {

        

        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();

            Console.WriteLine("entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}