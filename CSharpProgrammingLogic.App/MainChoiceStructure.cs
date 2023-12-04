using CSharpProgrammingLogic.App.ArrayExercises;
using CSharpProgrammingLogic.App.PrimitiveTypeExercises;

namespace CSharpProgrammingLogic.App
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
                    OddOrEven.Execute();
                    break;
                case 2:
                    Calculator.Execute();
                    break;
                case 3:
                    AnalyzeGrades.Execute();
                    break;
                case 4:
                    TriangleTypes.Execute();
                    break;
                case 5:
                    StringManipulation.Execute();
                    break;
                case 6:
                    TypeConversion.Execute(); //falta
                    break;
                case 7:
                    AreaCalculator.Execute(); //falta
                    break;
                case 8:
                    int[] numbersArray = ArrayIntegers.Execute();
                    ArrayFunctions.PrintFunctions(numbersArray);
                    break;
                case 9:
                    FindInArray.Execute();
                    break;
                case 10:
                    ArraySum.Execute();
                    break;
                case 11:
                    ArrayFunctions.Execute();
                    break;
                case 12:
                    _1To100Sum.Execute();
                    break;
                case 13:
                    DynamicArray.Execute();
                    break;
                case 14:
                    SortingAlgorithm.Execute(); //falta
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
                case 19:
                    DictionaryExercises.CountNumbers.Execute();
                    break;
                case 20:
                    DictionaryExercises.ChooseLanguage.Execute();
                    break;
                case 21:
                    DictionaryExercises.ExploringMethods.Execute();
                    break;
                default:
                    Console.WriteLine("Escolha inválida.\n");
                    Program.Main(args);
                    break;

            }
        }
    }
}
