using System;

namespace Array
{

    class program
    {

        static void Main(string[] args)
        {
            string[] carros = {"fusca", "brasilia", "onix", "volvo"};
            int[] numeros = {1, 2, 3, 4};

            //carros[2] = "passat amarelo"
            //Console.WriteLine(carros.Length);

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }
            
        }
    }
}