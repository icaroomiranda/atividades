using System;

public class Ex02
{
    public static void Executar()
    {
        double x1, y1, x2, y2;

        Console.Write("Digite x1: ");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("Digite y1: ");
        y1 = double.Parse(Console.ReadLine());

        Console.Write("Digite x2: ");
        x2 = double.Parse(Console.ReadLine());

        Console.Write("Digite y2: ");
        y2 = double.Parse(Console.ReadLine());

        double distancia = Math.Sqrt(
            Math.Pow(x2 - x1, 2) +
            Math.Pow(y2 - y1, 2)
        );

        Console.WriteLine("Distância: " + distancia.ToString("F2"));
    }
}