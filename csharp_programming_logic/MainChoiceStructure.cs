
namespace csharp_programming_logic
{
    internal class MainChoiceStructure
    {
        public static void ChooseProgram(int userChoice, string[] args)
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
                case 3:
                    PrimitiveTypeExercises.AnalyzeGrades.Execute();
                    break;
                case 4:
                    PrimitiveTypeExercises.TriangleTypes.Execute();
                    break;
                case 5:
                    PrimitiveTypeExercises.StringManipulation.Execute();
                    break;
                case 6:
                    PrimitiveTypeExercises.TypeConversion.Execute(); //falta
                    break;
                case 7:
                    PrimitiveTypeExercises.AreaCalculator.Execute(); //falta
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
                    ArrayExercises.SortingAlgorithm.Execute(); //falta
                    break;
                case 15:
                    BidimensionalArrayExercises.SumElements.Execute();
                    break;
                case 16:
                    BidimensionalArrayExercises.Identity.Execute(); 
                    break;
                case 17:
                    BidimensionalArrayExercises.Multiply.Execute(); 
                    break;
                case 18:
                    BidimensionalArrayExercises.SumLinesAndColumns.Execute(); 
                    break;
                default:
                    Console.WriteLine("Escolha inválida.\n");
                    Program.Main(args);
                    break;

            }
        }
    }
}
