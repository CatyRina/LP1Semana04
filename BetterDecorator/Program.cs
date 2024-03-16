using System;

namespace BetterDecorator
{
    static class StringExtensions
    {
        public static string Decorate(this string text, char character, int times)
        {
            string decoration = new string(character, times);
            return $"{decoration} {text} {decoration}";
        }
    }

    class Program
    {
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

            string decoratedText = text.Decorate(character, times);
            Console.WriteLine(decoratedText);
        }
    }
}

