using System;

namespace BetterDecorator
{
    /// <summary>
    /// Classe principal que contém o método de inicialização do programa.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada do programa.
        /// Aceita três argumentos da linha de comando e usa-os para decorar a string fornecida.
        /// </summary>
        /// <param name="args">Argumentos da linha de comando: [0] - texto, [1] - caractere, [2] - número de vezes.</param>
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Uso: dotnet run --project BetterDecorator \"texto\" \"caractere\" número");
                return;
            }

            string text = args[0];
            char character = args[1][0];
            int times = int.Parse(args[2]);

            string decoratedText = Decorate(text, character, times);
            Console.WriteLine(decoratedText);
        }

        /// <summary>
        /// Método que decora uma string fornecida com um caractere especificado repetido um certo número de vezes de cada lado.
        /// </summary>
        /// <param name="text">Texto a ser decorado.</param>
        /// <param name="character">Caractere usado para decoração.</param>
        /// <param name="times">Número de vezes que o caractere deve ser repetido de cada lado da string.</param>
        /// <returns>A string decorada.</returns>
        static string Decorate(string text, char character, int times)
        {
            string decoration = new string(character, times);
            return $"{decoration} {text} {decoration}";
        }
    }
}

