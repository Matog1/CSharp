using System;

namespace EntradaDeDados
{ 
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("qual a sua idade?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("i am " + age + " years old");

            Console.WriteLine("e qual o seu nome?");
            string name = Console.ReadLine();

            Console.WriteLine("ok " + name + "!");
        }
    } 
}


using System;


namespace EntradaDeDados
{

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("qual é o seu nome?");
        string Nome = Console.ReadLine();

        Console.WriteLine("qual é a sua idade?");
        int Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("meu nome é " + Nome + " e eu tenho " + Idade + " anos!");
        Console.WriteLine();
        }
    }
}