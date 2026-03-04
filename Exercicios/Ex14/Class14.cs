using System;

public class Ex14
{
    public static void Executar()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}