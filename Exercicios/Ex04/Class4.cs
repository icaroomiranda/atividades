using System;

public class Ex04
{
    public static void Executar()
    {
        double n1, n2, n3;

        Console.Write("Digite a primeira nota: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        n3 = double.Parse(Console.ReadLine());

        double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

        Console.WriteLine("Média ponderada: " + media.ToString("F2"));
    }
}