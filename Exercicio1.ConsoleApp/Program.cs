using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double [] altura = new double[15];
            double menorAltura = 0 , maiorAltura = 0;
            int i = 0;
          
           
            Console.WriteLine("insira a altura:");
            altura [0]= double.Parse(Console.ReadLine());
         

            altura = menorAltura;
            altura = maiorAltura;

            for (i = 1; i < 15; i++)
            {
                Console.WriteLine("digite a altura: ", i + 1);
                Console.WriteLine("{0}", altura);

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;                
                }
                else
                if (altura < menorAltura)
                {
                    menorAltura = altura;
                }
            }
            Console.WriteLine("maior altura: " + Math.Round(maiorAltura, 2));
            Console.WriteLine("menor altura: " + Math.Round(menorAltura, 2));
            



        }
    }
}
