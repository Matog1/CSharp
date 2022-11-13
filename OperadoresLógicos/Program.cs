using System;

namespace OperadoresLógicos
{

    class program
    {

        static void Main(string[] args)
        {

            //operador &&

            bool c1 = 2 > 3 && 4 != 5;

            //operador || (ou)

            bool c2 = 2 > 3 || 4 != 5;

            //operador ! (não)

            bool c3 = ! (2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3); 

        }
    }
}
