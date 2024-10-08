using System;
using git_project;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Calculadora POO em C#");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");

            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                continuar = false;
                continue;
            }

            if (true)
            {
                string j = "2";
            }

            if (true)
            {
                string j = "2";
            }

            if (true)
            {
                string j = "2";
            }

            string teste = "3";

            Console.WriteLine("Digite o primeiro número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                double resultado = 0;
                switch (opcao)
                {
                    case "1":
                        resultado = calculator.Add(numero1, numero2);
                        Console.WriteLine($"Resultado da Adição: {resultado}");
                        break;
                    case "2":
                        resultado = calculator.Subtract(numero1, numero2);
                        Console.WriteLine($"Resultado da Subtração: {resultado}");
                        break;
                    case "3":
                        resultado = calculator.Multiply(numero1, numero2);
                        Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                        break;
                    case "4":
                        resultado = calculator.Divide(numero1, numero2);
                        Console.WriteLine($"Resultado da Divisão: {resultado}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Obrigado por usar a calculadora!");
    }
}
