using System;

public class Ex18
{
    public static void Executar()
    {
        int soma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite a idade: ");
            soma += int.Parse(Console.ReadLine());
        }

        double media = soma / 5.0;

        Console.WriteLine("Média das idades: " + media.ToString("F2"));
    }
}