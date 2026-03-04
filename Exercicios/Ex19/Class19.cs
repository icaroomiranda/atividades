usinusing System;

public class Ex19
{
    public static void Executar()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        bool primo = true;

        if (n <= 1)
            primo = false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                primo = false;
                break;
            }
        }

        if (primo)
            Console.WriteLine("Número primo");
        else
            Console.WriteLine("Não é primo");
    }
}