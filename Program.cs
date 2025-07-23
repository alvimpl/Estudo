using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Escolha a opção desejada!: ");
        Console.WriteLine("1 Calculadora | 2 Par ou Ímpar | 3 Conversor Temperatura | 4 Tabuada | 5 Contador de Palavras | 6 Números Primos");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                calculadora();
                break;
            case "2":
                parImpar();
                break;
            case "3":
                conversor();
                break;
            case "4":
                tabuada();
                break;
            case "5":
                contadorPalavras();
                break;
            case "6":
                numerosPrimos();
                break;
            defaut:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    private static void numerosPrimos()
    {
        Console.WriteLine("Digite um número para ver todos primos de 0 até ele: ");
        string input = Console.ReadLine();
        bool validacao = int.TryParse(input, out int numero);

        if (!validacao) {
            Console.WriteLine("Dado inserido não é válido!");
            return;
        }

        Console.WriteLine($"Os números primos até {numero} são: ");
            for ( int i = 2; i <= numero; i++ )
        {
            if (Primos(i))
            {
                Console.Write(i + " ");
            }
        }

        static bool Primos(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            } return true;
        }

    }

    private static void contadorPalavras()
    {
        Console.WriteLine("Digite uma pequena frase: ");
        string input = Console.ReadLine();

        string[] palavras = input.Split(new char[] { ' ', '.', ',', '-', '_', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"Você digitou {palavras.Length} palavras nesta frase!");
    }
    private static void tabuada()
    {
        Console.WriteLine("Escolha um número: ");
        string input = Console.ReadLine();

        bool validarNumero = double.TryParse(input, out double numero);

        if (validarNumero)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Tabuada de {numero} : {numero} x {i} = {numero * i}");
            }
        }
        else { Console.WriteLine("Número inválido!"); }
    }

    private static void conversor()
    {
        Console.WriteLine("Conversão de Celsius para Farenheit, digite a temperatura para conversão: ");
        string input = Console.ReadLine();
        bool validacao = double.TryParse(input, out double celsius);

        if (validacao)
        {
            Console.WriteLine($"A conversão de {celsius}C em Farenheit é {(celsius * 9 / 5) + 32}F");
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
    }

    private static void parImpar()
    {
        Console.WriteLine("Digite um número para saber se é par ou ímpar: ");
        string input = Console.ReadLine();

        bool validacao = double.TryParse(input, out double numero);
        if (validacao)
        {
            Console.WriteLine($"O número {input} é {(numero % 2 == 0 ? "Par" : "Ímpar")}.");
        }
        else { Console.WriteLine("Número inválido!"); }
    }

    private static void calculadora()
    {
        Console.WriteLine("Selecione a operação: + - * /");
        string operacao = Console.ReadLine();

        Console.WriteLine("Digite o primeiro número: ");
        string inputA = Console.ReadLine();
        bool validacaoA = double.TryParse(inputA, out double numeroA);

        Console.WriteLine("Digite o segundo número: ");
        string inputB = Console.ReadLine();
        bool validacaoB = double.TryParse(inputB, out double numeroB);

        if (validacaoA && validacaoB)
        {
            switch (operacao)
            {
                case "+":
                    Console.WriteLine($"A soma de {numeroA} + {numeroB} é {numeroA + numeroB}.");
                    break;

                case "-":
                    Console.WriteLine($"A subtração de {numeroA} - {numeroB} é {numeroA - numeroB}.");
                    break;

                case "*":
                    Console.WriteLine($"A multiplicação de {numeroA} X {numeroB} é {numeroA * numeroB}.");
                    break;

                case "/":
                    if (numeroB != 0)
                    {
                        Console.WriteLine($"A divisão de {numeroA} / {numeroB} é {numeroA / numeroB}.");
                    }
                    else { Console.WriteLine("Não é possível dividir por 0"); }
                    break;

                defaut:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
        }
        else { Console.WriteLine("Digitou números inválidos!"); }

    }
}

