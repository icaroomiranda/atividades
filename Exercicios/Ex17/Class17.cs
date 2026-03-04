using System;

public class Ex17
{
    public static void Executar()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Divisores:");

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
    }
}