using System;

namespace CondiçãoFor
{

    class program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(i);
            }

            string[] carros = { "fusca", "brasília", "varianti" };

            foreach (string y in carros)
            {
                Console.WriteLine(y);
            }
        }
    }
}
