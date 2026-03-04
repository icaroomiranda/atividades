using System;

public class Ex12
{
    public static void Executar()
    {
        int soma = 0;
        int contador = 0;

        do
        {
            Console.Write("Digite um número: ");
            soma += int.Parse(Console.ReadLine());
            contador++;
        }
        while (contador < 5);

        Console.WriteLine("Soma: " + soma);
    }
}