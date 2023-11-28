
using LibFormatOutput;
using LibUserInput;

namespace csharp_programming_logic.PrimitiveTypeExercises
{
    internal class AnalyzeGrades
    {
        internal static void Execute()
        {
            PrintTitle();
            float grade = Receive.Grade();  
            string isTheStudentApproved = (grade >= 7) ? "Aprovado" : "Reprovado";
            Console.WriteLine(isTheStudentApproved);
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\nVERIFICAÇÃO DE NOTA");
            Print.HorizontalLine();
        }
    }
}