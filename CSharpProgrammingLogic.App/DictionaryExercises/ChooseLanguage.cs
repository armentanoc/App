using LibFormatOutput;
using LibUserInput;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharpProgammingLogic.App.DictionaryExercises
{
    internal class ChooseLanguage
    {
        internal static void Execute()
        {
            var translations = new Dictionary<int, Dictionary<int, string>>

            {
                [1] = new Dictionary<int, string> { [1] = "Olá", [2] = "Mundo" },
                [2] = new Dictionary<int, string> { [1] = "Hello", [2] = "World" },
                [3] = new Dictionary<int, string> { [1] = "Hola", [2] = "Mundo" }
            };

            PrintTitle();

            while (true)
            {
                Console.WriteLine("\nVocê deverá selecionar um idioma para exibição do programa\n1 - Português \n2 - Inglês \n3 - Espanhol \n0 - Sair\n");
                int languageKey = Receive.IntNumber();

                if(languageKey == 0)
                {
                    break;
                }

                if (translations.ContainsKey(languageKey))
                {
                    PrintTranslations(translations.GetValueOrDefault(languageKey));
                }
                else
                {
                    Console.WriteLine("Entrada de idioma inválida. Por favor, tente novamente.");
                }
            }

            static void PrintTranslations(Dictionary<int, string> languageDictionary)
            {
                if (languageDictionary is not null)
                {
                    foreach (var (id, translation) in languageDictionary)
                    {
                        Console.Write($"{translation} ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Idioma não suportado.");
                }
            }
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\nESCOLHA DE IDIOMA PARA O PROGRAMA");
            Print.HorizontalLine();
        }
    }
}