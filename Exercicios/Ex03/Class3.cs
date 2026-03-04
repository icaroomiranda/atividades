using System;

public class Ex03
{
    public static void Executar()
    {
        int A, B, C;

        Console.Write("Digite A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        B = int.Parse(Console.ReadLine());

        Console.Write("Digite C: ");
        C = int.Parse(Console.ReadLine());

        int R = (A + B) * (A + B);
        int S = (B + C) * (B + C);
        int D = R + S;

        Console.WriteLine("Valor de D: " + D);
    }
}