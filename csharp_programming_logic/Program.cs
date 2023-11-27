using System;
using csharp_programming_logic.PrimitiveTypeExercises;
using LibFormatOutput;
using LibUserInput;

namespace csharp_programming_logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = -1;

            while (userChoice != 0)
            {
                Print.HorizontalLine();
                Console.WriteLine("\nC# PROGRAMMING LOGIC\n");
                Console.WriteLine("Escolha um programa para executar:\n");
                //Console.WriteLine("1 - Par ou ímpar");
                //Console.WriteLine("2 - Calculadora");
                Console.WriteLine("8 - Array simples de inteiros");
                Console.WriteLine("9 - Buscar elemento em um array");
                Console.WriteLine("10 - Soma de vetores");
                Console.WriteLine("11 - Funções em vetores");
                Console.WriteLine("12 - Soma de 1 a 100");
                Console.WriteLine("13 - Array Dinâmico");
                Console.WriteLine("14 - Algoritmo de ordenação");
                Console.WriteLine("0 - Encerrar\n");
                Print.HorizontalLine();

                userChoice = Receive.IntNumber();
                ChooseProgram(userChoice, args);
            }
        }

        private static void ChooseProgram(int userChoice, string[] args)
        {
            switch (userChoice)
            {
                case 0:
                    Console.WriteLine("\nO programa será encerrado.\n");
                    break;
                case 1:
                    PrimitiveTypeExercises.OddOrEven.Execute();
                    break;
                case 2:
                    PrimitiveTypeExercises.Calculator.Execute();
                    break;
                case 8:
                    int[] numbersArray = ArrayExercises.ArrayIntegers.Execute();
                    ArrayExercises.ArrayFunctions.PrintFunctions(numbersArray);
                    break;
                case 9:
                    ArrayExercises.FindInArray.Execute();
                    break;
                case 10:
                    ArrayExercises.ArraySum.Execute();
                    break;
                case 11:
                    ArrayExercises.ArrayFunctions.Execute();
                    break;
                case 12:
                    ArrayExercises._1To100Sum.Execute();
                    break;
                case 13:
                    ArrayExercises.DynamicArray.Execute();
                    break;
                case 14:
                    ArrayExercises.SortingAlgorithm.Execute();
                    break;
                default:
                    Console.WriteLine("Escolha inválida.\n");
                    Main(args);
                    break;
            }
        }
    }
}
