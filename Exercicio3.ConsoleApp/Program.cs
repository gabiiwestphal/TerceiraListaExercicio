using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 500; i++)
            {
                if ((i % 2) != 0)
                {
                    if (i % 3 == 0)
                    {
                        soma = soma + i;
                    }
                }
            }
            Console.WriteLine("o resultado da soma é: {0} ", soma);
        }
    }
}
