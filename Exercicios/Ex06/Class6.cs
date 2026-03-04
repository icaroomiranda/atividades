using System;

public class Ex06
{
    public static void Executar()
    {
        int a, b, c;

        Console.Write("Digite o primeiro número: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        c = int.Parse(Console.ReadLine());

        int maior = a;

        if (b > maior) maior = b;
        if (c > maior) maior = c;

        Console.WriteLine("Maior número: " + maior);
    }
}