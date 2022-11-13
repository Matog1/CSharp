using System;

namespace Switch
{

    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("digite um dia da semana (1- segunda, 2- terça, 3- quarta, 4- quinta, 5-sexta, 6- sábado e 7- domingo)");

            int dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("segunda-feira");
                        break;
                case 2:
                    Console.WriteLine("terça-feira");
                    break;
                case 3:
                    Console.WriteLine("quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("sábado");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;

                default:

                    Console.WriteLine("o valor informado não existe!");

                    break;
            }
        }
    }
}
