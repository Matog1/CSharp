using System;

namespace IfElse
{

    class Program
    {

        static void Main(string[]args)
        {

            /* bool eugostodegoiaba = true;
             if (eugostodegoiaba == true)
             {
                 Console.WriteLine("eu compro!");
             }
             else
             {
                 Console.WriteLine("eu não compro!");
             }*/

            /*Console.WriteLine("digite um número");

            int time = Convert.ToInt32(Console.ReadLine());

            if (time < 12)  
            {
                Console.WriteLine("bom dia");
            }
            else if(time < 18)
            {
                Console.WriteLine("boa tarde");
            }
            else
            {
                Console.WriteLine("boa noite");
            }*/


            /*Console.WriteLine("digite um número inteiro:");
            int x = int.Parse(Console.ReadLine());


            if (x % 2 == 0) 
            {
                Console.WriteLine("você digitou um número par!");
            }
            else
            {
                Console.WriteLine("você digitou um número ímpar!");
            }*/

            Console.WriteLine("qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("boa tarde!");
            }
            else if (hora >= 18)
            {
                Console.WriteLine("boa noite!");
            }
            else
            {
                Console.WriteLine("boa madrugada!");
            }

            

        }
    }
}