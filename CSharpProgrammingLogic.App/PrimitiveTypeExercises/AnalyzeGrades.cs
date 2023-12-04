
using LibFormatOutput;
using LibUserInput;

namespace CSharpProgammingLogic.App.PrimitiveTypeExercises
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

        static void PrintTitle()
        {
            Console.WriteLine("\nVERIFICAÇÃO DE NOTA");
            Print.HorizontalLine();
        }
    }
}