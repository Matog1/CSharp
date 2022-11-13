using System;

namespace CondiçãoFor
{

    class program
    {

        static void Main(string[] args)
        {
            //for (int i = 0; i < 8; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < 8; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


        }
    }
}
