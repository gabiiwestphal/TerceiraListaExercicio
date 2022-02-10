using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza o numero a ser calculado a fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            if (num != 0)
            {
                for (int i = 1; i <= num; i++) fatorial = fatorial * i;
            }

            Console.WriteLine("Fatorial de " + num + " = " + fatorial);
        }

    }
    }



        
    

