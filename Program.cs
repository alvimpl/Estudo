using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Escolha a opção desejada!: ");
        Console.WriteLine("1 Calculadora | 2 Par ou Ímpar | 3 Conversor Temperatura | 4 Tabuada | 5 Contador de Palavras | 6 Números Primos | 7 Contador de Letras | 8 IMC | 9 Adivinha Número | 10 Palindromo");
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
            case "7":
                contaLetras();
                break;
            case "8":
                imc();
                break;
            case "9":
                adivinhaNumero();
                break;
            case "10":
                palindromo();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    private static void imc()
    {
        Console.WriteLine("Vamos saber seu IMC!");
        Console.WriteLine("Digite seu peso: ");
        string inputPeso = Console.ReadLine();
        bool validaPeso = double.TryParse(inputPeso, out double peso);
        Console.WriteLine("Digite sua altura (cm): ");
        string inputAltura = Console.ReadLine();
        bool validaAltura = double.TryParse(inputAltura, out double altura);

        if (validaPeso && validaAltura)
        {
            double imc = (peso / (altura * altura) * 10000);
            Console.WriteLine($"Seu IMC é {imc:F2}.");

        }
    }

    private static void adivinhaNumero()
    {
        Console.WriteLine("Adivinhe o número entre 1 e 10");

        Random random = new Random();
        int aleatorio = random.Next(1, 10);
        int contadorTentativas = 0;
        int digitado = 0;

        while (digitado != aleatorio)
        {

            Console.WriteLine("Digite um número: ");
            string nDigitado = Console.ReadLine();
            bool validado = int.TryParse(nDigitado, out int escolhido);
            digitado = escolhido;

            if (!validado)
            {
                Console.WriteLine("Número inválido!");
                return;
            }

            contadorTentativas++;

            if (escolhido < aleatorio)
            {
                Console.WriteLine("O número digitado é MENOR que o esperado:");
            }
            else if (escolhido > aleatorio)
            {
                Console.WriteLine("O número digitado é MAIOR que o esperado.");
            }
            else if (escolhido == aleatorio)
            {
                Console.WriteLine($"Parabéns, você acertou em {contadorTentativas} tentativas!");
            }
        }
    }

    private static void palindromo()
    {
        Console.WriteLine("A palavra ou frase é um palíndromo?");
        Console.WriteLine("Digite uma palavra ou frase (sem acentuação ou caracteres especiais): ");
        string input = Console.ReadLine();
        input = Ajuste(input);
        string invertido = new string(input.ToCharArray().Reverse().ToArray());

        if (input == invertido)
        {
            Console.WriteLine("É palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é palíndromo!");
        }

        static string Ajuste(string txt)
        {
            txt = txt.ToLower().Replace(" ", "").Replace(" .", "").Replace(" ,", "").Replace(" .", "").Replace("-", "").Replace("!", "").Replace("?", "");
            return txt;
        }
    }

    private static void contaLetras()
    {
        Console.WriteLine("Digite uma frase para fazermos a conta de letras: ");
        string frase = Console.ReadLine();

        frase = frase.ToLower().Replace(" ", "");

        int contaVogais = 0;
        int contaConsoantes = 0;
        int contaOutros = 0;

        foreach (char caracter in frase)
        {
            if ("aeiou".Contains(caracter))
            {
                contaVogais++;
            }
            else if ("bcdfghjklmnpqrstvwyz".Contains(caracter))
            {
                contaConsoantes++;
            }
            else
            {
                contaOutros++;
            }
        }
        Console.WriteLine($"Sua frase tem {contaVogais} vogal(is), {contaConsoantes} consoante(s) e {contaOutros} outro(s) caracter(es).");
    }

    private static void numerosPrimos()
    {
        Console.WriteLine("Insira um número: ");
        string input = Console.ReadLine();
        bool validacao = int.TryParse(input, out int numero);

        if (!validacao)
        {
            Console.WriteLine("Dados inválidos!");
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

        static bool Primos(int n) {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0) return false;

            } return true;
        }
    }

    private static void contadorPalavras()
    {
        Console.WriteLine("Digite uma frase: ");
        string input = Console.ReadLine();

        string[] palavras = input.Split(new char[] { ' ', '.', ',', '-', '_', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"Sua frase possui {palavras.Length} palavras");
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

