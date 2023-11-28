


using System.Drawing;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibUserInput
{
    public class Receive
    {
        public static int IntNumber()
        {
            int number;

            while (true)
            {
                Console.Write("Informe um número: ");
                if (int.TryParse(Console.ReadLine(), out number)) { break; }
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido (inteiro).\n");
            }

            return number;
        }

        public static float FloatNumber()
        {
            float number;

            while (true)
            {
                Console.Write("Informe um número: ");
                if (float.TryParse(Console.ReadLine(), out number)) { break; }
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido (float).\n");
            }

            return number;
        }

        public static float Grade()
        {
            float grade;

            while (true)
            {
                Console.Write("Informe a nota: ");
                if (float.TryParse(Console.ReadLine(), out grade) && IsGradeValid(grade))
                {
                    break;
                }
                Console.WriteLine("Erro: Nota inválida. Por favor, insira uma nota entre 0 e 10.\n");
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
                Console.Write($"Informe o lado {order} do triângulo: ");
                if (float.TryParse(Console.ReadLine(), out side) && side > 0)
                {
                    break;
                }
                Console.WriteLine("Erro: O lado precisa ser um número maior que 0.\n");
            }

            return side;
        }

        public static string Name()
        {
            string name;

            while (true)
            {
                Console.Write($"Informe o seu nome: ");
                name = Console.ReadLine();
                
                if (IsValidName(name)) 
                { 
                    break; 
                }

                Console.WriteLine("Erro: O nome não pode ser vazio ou conter caracteres numéricos.\n");
            }
            return name;
        }

        static bool IsValidName(string name)
        {
            // Check if the name is not null, empty, or contains digits
            return !string.IsNullOrWhiteSpace(name) && !Regex.IsMatch(name, @"\d");
        }

        public static int ProgramNumber()
        {
            int choice = -1;

            while (true)
            {
                Console.Write("Escolha um programa para executar: ");
                if (int.TryParse(Console.ReadLine(), out choice)) { break; }
                Console.WriteLine("Erro: Digite um número inteiro de 0 a .\n");
            }

            return choice;
            
        }
    }
}
