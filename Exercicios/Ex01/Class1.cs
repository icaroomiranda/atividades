using System;

public class Ex01
{
    public static void Executar()
    {
        int num1, num2;

        Console.Write("Digite o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Soma: " + (num1 + num2));
        Console.WriteLine("Subtração: " + (num1 - num2));
        Console.WriteLine("Multiplicação: " + (num1 * num2));
        Console.WriteLine("Divisão: " + ((double)num1 / num2));
    }
}