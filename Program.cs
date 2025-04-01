using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Menu();
            
        } 
    
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Qual operação matemática desejar executar? ");
        Console.WriteLine("");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - DIVISÃO");
        Console.WriteLine("4 - MULTIPLICAÇÃO");
        Console.WriteLine("5 - SAIR");

        Console.WriteLine("-----------------------");
        Console.WriteLine("Selecione uma das opções acima. ");
        string? input = Console.ReadLine();
        short result;

        while(!short.TryParse(input, out result) || result <1 || result >5)
        {
            Console.Clear();
            Console.WriteLine("Tecla inválida! Escolha uma das opções de 1 a 5. ");c
            input = Console.ReadLine();
    
        }

        switch (result){
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Exitcalc(); break;
            default: Menu(); break;
        }

    }
    static void Soma()
    {
         Console.Clear();
            Console.WriteLine("A seguir faremos a soma de 2 valores. ");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            string? input1 = Console.ReadLine();
            float valor1;
            while(!float.TryParse(input1, out valor1))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Segundo Valor: ");
            string? input2 = Console.ReadLine();
            float valor2;
            while(!float.TryParse(input2, out valor2))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Aperte QUALQUER tecla para continuar...");
            Console.ReadKey();
            Menu();
    }
    static void Subtracao()
    {
        Console.Clear();
            Console.WriteLine("A seguir faremos a subtração de 2 valores. ");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            string? input1 = Console.ReadLine();
            float valor1;
            while(!float.TryParse(input1, out valor1))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Segundo Valor: ");
            string? input2 = Console.ReadLine();
            float valor2;
            while(!float.TryParse(input2, out valor2))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Aperte QUALQUER tecla para continuar...");
            Console.ReadKey();
            Menu();
    } 
    static void Divisao()
    {
         Console.Clear();
            Console.WriteLine("A seguir faremos a divisão de 2 valores. ");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            string? input1 = Console.ReadLine();
            float valor1;
            while(!float.TryParse(input1, out valor1))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Segundo Valor: ");
            string? input2 = Console.ReadLine();
            float valor2;
            while(!float.TryParse(input2, out valor2))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("");

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Aperte QUALQUER tecla para continuar...");
            Console.ReadKey();
            Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();
            Console.WriteLine("A seguir faremos a multiplicação de 2 valores. ");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            string? input1 = Console.ReadLine();
            float valor1;
            while(!float.TryParse(input1, out valor1))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Segundo Valor: ");
            string? input2 = Console.ReadLine();
            float valor2;
            while(!float.TryParse(input2, out valor2))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido! Digite um número válido: ");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Aperte QUALQUER tecla para continuar...");
            Console.ReadKey();
            Menu();
    }
    
    static void Exitcalc()
    {
        Console.Clear();

        Console.WriteLine("Obrigado por utilizar esse simples programa de cálculo =)");
        Console.WriteLine("");
        Console.WriteLine("A aplicação foi finalizada! ");
        Console.WriteLine("");
        Console.WriteLine("");

        return;
    }

    }
    // Chave que fecha a class Program

}
// Ultima chave do programa