using System;
using csharp_programming_logic.PrimitiveTypeExercises;
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

                PrimitiveTypeChoices();
                ArrayChoices();
                BidimensionalArrayChoices();

                userChoice = Receive.IntNumber();
                MainChoiceStructure.ChooseProgram(userChoice, args);

                Thread.Sleep(3000); //pause for 3 seconds
            }
        }

        private static void PrintTitle()
        {
            Print.HorizontalLine();
            Console.WriteLine("C# PROGRAMMING LOGIC\n");
            Console.WriteLine("Escolha um programa para executar:\n");
            Console.WriteLine("0 - Encerrar");
            Print.HorizontalLine();
        }

        private static void PrimitiveTypeChoices()
        {
            Console.WriteLine("1 - Par ou ímpar");
            Console.WriteLine("2 - Calculadora");
            Console.WriteLine("3 - Aprovação em disciplina");
            Console.WriteLine("4 - Identificação de triângulos");
            Console.WriteLine("5 - Manipulação de strings");
            Console.WriteLine("6 - Conversão de tipos");
            Console.WriteLine("7 - Cálculo de área");
            Print.HorizontalLine();
        }

        private static void ArrayChoices()
        {
            Console.WriteLine("8 - Array simples de inteiros");
            Console.WriteLine("9 - Buscar elemento em um array");
            Console.WriteLine("10 - Soma de vetores");
            Console.WriteLine("11 - Funções em vetores");
            Console.WriteLine("12 - Soma de 1 a 100");
            Console.WriteLine("13 - Array Dinâmico");
            Console.WriteLine("14 - Algoritmo de ordenação");
            Print.HorizontalLine();
        }

        private static void BidimensionalArrayChoices()
        {
            Console.WriteLine("15 - Soma de matriz de inteiros");
            Console.WriteLine("16 - Verificação de matriz identidade");
            Console.WriteLine("17 - Multiplicação de matrizes");
            Console.WriteLine("18 - Soma de linhas e colunas em matriz bidimensional");
            Print.HorizontalLine();
        }
    }
}
