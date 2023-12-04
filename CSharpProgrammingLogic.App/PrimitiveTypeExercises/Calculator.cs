
using LibUserInput;

namespace csharp_programming_logic.PrimitiveTypeExercises
{
    internal class Calculator
    {
        public static void Execute() {

            Console.WriteLine("\nOPERAÇÕES MATEMÁTICAS");
            Console.WriteLine("\nVocê deve informar dois números e, na sequência, a operação desejada.");
            float firstNumber = Receive.FloatNumber();
            float secondNumber = Receive.FloatNumber();
            float result = Calculate.MathOperation(firstNumber, secondNumber);
            Console.WriteLine($"\nO resultado da operação é {result}.\n");
        }
    }
}
