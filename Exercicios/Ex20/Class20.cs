using System;

namespace Exercicios
{
    public class Ex20
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Dobro: " + (n * 2));
            Console.WriteLine("Triplo: " + (n * 3));
            Console.WriteLine("Raiz quadrada: " + Math.Sqrt(n).ToString("F2"));
        }
    }
}