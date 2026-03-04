usinusing System;

public class Ex16
{
    public static void Executar()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        int fatorial = 1;

        for (int i = 1; i <= n; i++)
            fatorial *= i;

        Console.WriteLine("Fatorial: " + fatorial);
    }
}