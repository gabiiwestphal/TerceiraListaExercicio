using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int contador = 0 ;
            int total;

            Console.WriteLine("Digite o n: ");
            n = int.Parse(Console.ReadLine());

            for (contador = 0; contador <=10; contador++)
            {
                total = n * contador;
                Console.WriteLine( n + " x " + contador + " = " + total);
            }
               
        }
    }
}
