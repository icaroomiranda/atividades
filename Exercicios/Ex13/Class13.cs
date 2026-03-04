using System;

public class Ex13
{
    public static void Executar()
    {
        Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Resultado: " + (a + b));
                break;
            case "-":
                Console.WriteLine("Resultado: " + (a - b));
                break;
            case "*":
                Console.WriteLine("Resultado: " + (a * b));
                break;
            case "/":
                Console.WriteLine("Resultado: " + (a / b));
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }
    }
}