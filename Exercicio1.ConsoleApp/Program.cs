using System;
using System.Linq;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float[] altura = new float[15];

            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write($"-Digite a altura da {i + 1}ª pessoa: ");
                altura[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A menor altura do grupo é: {altura.Min()}m");
            Console.WriteLine($"A maior altura do grupo é: {altura.Max()}m");
            Console.ReadLine();

        }
    }
}
