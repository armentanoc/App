


using System.Drawing;
using System.Text.RegularExpressions;

namespace LibUserInput
{
    public class Receive
    {

        public static int IntNumber()
        {
            int number;

            while (true)
            {
                Console.Write("\nInforme um número: ");
                if (int.TryParse(Console.ReadLine(), out number)) { break; }
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido (inteiro).");
            }

            return number;
        }

        public static float FloatNumber()
        {
            float number;

            while (true)
            {
                Console.Write("\nInforme um número: ");
                if (float.TryParse(Console.ReadLine(), out number)) { break; }
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido (float).");
            }

            return number;
        }

        public static float Grade()
        {
            float grade;

            while (true)
            {
                Console.Write("\nInforme a nota: ");
                if (float.TryParse(Console.ReadLine(), out grade) && IsGradeValid(grade))
                {
                    break;
                }
                Console.WriteLine("Erro: Nota inválida. Por favor, insira uma nota entre 0 e 10.");
            }

            return grade;
        }

        public static bool IsGradeValid(float grade)
        {
            return grade >= 0 && grade <= 10;
        }

        public static float TriangleSide(int order)
        {

            float side;

            while (true)
            {
                Console.Write($"\nInforme o lado {order} do triângulo: ");
                if (float.TryParse(Console.ReadLine(), out side) && side > 0)
                {
                    break;
                }
                Console.WriteLine("Erro: O lado precisa ser um número maior que 0.");
            }

            return side;
        }

        public static string Name()
        {
            string name;

            while (true)
            {
                Console.Write($"\nInforme o seu nome: ");
                name = Console.ReadLine();
                
                if (IsValidName(name)) 
                { 
                    break; 
                }

                Console.WriteLine("Erro: O nome não pode ser vazio ou conter caracteres numéricos.");
            }
            return name;
        }

        private static bool IsValidName(string name)
        {
            // Check if the name is not null, empty, or contains digits
            return !string.IsNullOrWhiteSpace(name) && !Regex.IsMatch(name, @"\d");
        }
    }
}
