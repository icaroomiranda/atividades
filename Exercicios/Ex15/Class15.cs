using System;

public class Ex15
{
    public static void Executar()
    {
        int pares = 0, impares = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("Pares: " + pares);
        Console.WriteLine("Ímpares: " + impares);
    }
}