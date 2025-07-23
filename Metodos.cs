using System;

class Metodos
{

    public void Main()
    {

        Console.WriteLine("Vamos achar os números primos?");
        string input = Console.ReadLine();
        bool validacao = int.TryParse(input, out int numero);

        if (!validacao)
        {
            Console.WriteLine("Não é uma entrada válida para esta operação!");
            return;
        }

        Console.WriteLine($"Os números primos até {numero} são: ");

        for (int i = 2; i <= numero; i++)
        {
            if (Primos(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    private static bool Primos(int n)
    {
        if (n <= 0) return false;
        for (int i = 0; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;

        } return true;
            }
}

