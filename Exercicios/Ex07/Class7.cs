using System;

public class Ex07
{
    public static void Executar()
    {
        int n1, n2;

        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
            Console.WriteLine("Maior: " + n1);
        else if (n2 > n1)
            Console.WriteLine("Maior: " + n2);
        else
            Console.WriteLine("Números iguais");
    }
}