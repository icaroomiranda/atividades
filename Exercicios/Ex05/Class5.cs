using System;

public class Ex05
{
    public static void Executar()
    {
        int numero;

        Console.Write("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine("Número PAR");
        else
            Console.WriteLine("Número ÍMPAR");
    }
}