
using LibFormatOutput;
using LibUserInput;

namespace csharp_programming_logic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int userChoice = -1;

            while (userChoice != 0)
            {
                PrintTitle();

                int currentNumber = 1;

                PrintChoices("Primitive Type Exercises", new string[]
                {
                "Par ou ímpar",
                "Calculadora",
                "Aprovação em disciplina",
                "Identificação de triângulos",
                "Manipulação de strings",
                "Conversão de tipos",
                "Cálculo de área"
                }, ref currentNumber);

                PrintChoices("Array Exercises", new string[]
                {
                "Array simples de inteiros",
                "Buscar elemento em um array",
                "Soma de vetores",
                "Funções em vetores",
                "Soma de 1 a 100",
                "Array Dinâmico",
                "Algoritmo de ordenação"
                }, ref currentNumber);

                PrintChoices("Bidimensional Array Exercises", new string[]
                {
                "Soma de matriz de inteiros",
                "Verificação de matriz identidade",
                "Multiplicação de matrizes",
                "Soma de linhas e colunas em matriz bidimensional"
                }, ref currentNumber);

                PrintChoices("Dictionary Exercises", new string[]
                {
                "Contador de números em array",
                "Escolha de idioma de exibição",
                "Explorando os métodos"
                }, ref currentNumber);

                userChoice = Receive.ProgramNumber();
                MainChoiceStructure.ChooseProgram(userChoice, args);

                Thread.Sleep(3000); // Pause for 3 seconds
            }
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nC# PROGRAMMING LOGIC");
            Print.HorizontalLine();
            Console.WriteLine("0 - Encerrar");
            Print.HorizontalLine();
        }

        static void PrintChoices(string sectionTitle, string[] choices, ref int currentNumber)
        {
            Console.WriteLine($"{sectionTitle}\n");

            for (int i = 0; i < choices.Length; i++)
            {
                Console.Write($"{currentNumber + i} - {choices[i]}; ");
            }

            Console.WriteLine();
            Print.HorizontalLine();

            currentNumber += choices.Length; // Update the current number for the next section
        }
    }
}
