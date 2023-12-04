
using LibUserInput;
using LibFormatOutput;

namespace csharp_programming_logic.ArrayExercises
{
    public class FindInArray
    {
        public static void Execute()
        {
            Print.HorizontalLine();
            Console.WriteLine("\nPROCURANDO NÚMERO EM UM ARRAY");
            
            int[] numbersArray = ArrayExercises.ArrayIntegers.Execute();

            Print.HorizontalLine();
            Console.WriteLine("\nAGORA, VOCÊ DEVE INFORMAR O NÚMERO A SER PESQUISADO");
            
            int numberToSearch = Receive.IntNumber();
            SearchForNumber(numberToSearch, numbersArray);
        }

        static void SearchForNumber(int numberToSearch, int[] numbersArray)
        {
            int index = Array.IndexOf(numbersArray, numberToSearch);

            if (index != -1)
            {
                Console.WriteLine($"\nNúmero {numberToSearch} encontrado no índice {index} do array.\n");
            }
            else
            {
                Console.WriteLine($"\nNúmero {numberToSearch} não encontrado no array.");
            }
        }
    }
}