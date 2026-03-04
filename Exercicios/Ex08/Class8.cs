using System;

public class Ex08
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

        if (a > 0 && b > 0 && c > 0)
        {
            int soma = a + b + c;
            Console.WriteLine("Soma: " + soma);
        }
        else
        {
            Console.WriteLine("Erro: Todos os números devem ser positivos.");
        }
    }
}