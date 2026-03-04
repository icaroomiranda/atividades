using System;
using System;

public class Ex11
{
    public static void Executar()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("Positivo");
        else if (n < 0)
            Console.WriteLine("Negativo");
        else
            Console.WriteLine("Zero");
    }
}