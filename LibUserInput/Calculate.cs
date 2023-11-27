using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibUserInput
{
    public class Calculate
    {
        public static float MathOperation(float firstNumber, float secondNumber)
        {
            bool validOperation = false;
            int operationChoice = 0;

            Console.WriteLine("\nAgora, informe a operação a ser realizada: ");
            Console.WriteLine("\n1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            while (!validOperation)
            {
                operationChoice = Receive.IntNumber();

                if (Regex.IsMatch(Convert.ToString(operationChoice), "^[1-4]$"))
                    {
                        validOperation = true;
                    }
                else
                {
                    Console.WriteLine("Operação inválida. Digite um número de 1 a 4.");
                }
                }

            return GetResultOfOperation(firstNumber, secondNumber, operationChoice);

            }

        private static float GetResultOfOperation(float firstNumber, float secondNumber, int operationChoice)
        {

            float result = 0;

            switch (operationChoice) {
                case 1: //Adição
                    result = Sum(firstNumber, secondNumber); break;
                case 2: //Subtração
                    result = Subtract(firstNumber, secondNumber); break;
                case 3: //Multiplicação
                    result = Multiply(firstNumber, secondNumber); break;
                case 4: //Divisão
                    result = Divide(firstNumber, secondNumber); break;
                default:
                    Console.WriteLine("Erro inesperado. ");
                    return Calculate.MathOperation(firstNumber, secondNumber);
            }

            return result;
        }

        private static float Divide(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private static float Multiply(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private static float Subtract(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private static float Sum(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
