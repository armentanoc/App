
using LibUserInput;

namespace csharp_programming_logic.PrimitiveTypeExercises
{
    internal class OddOrEven
    {
        public static void Execute()
        {

            Console.WriteLine("\nPAR OU ÍMPAR");
            int number = Receive.IntNumber();
            if (number % 2 == 0)
            {
                Console.WriteLine($"\nO número {number} é par.\n");
            }
            else
            {
                Console.WriteLine($"\nO número {number} é ímpar.\n");
            }
        }
    }
}
