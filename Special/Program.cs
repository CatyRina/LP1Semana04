using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = int.Parse(Console.ReadLine());

            int result = GetSpecial(n);
            Console.WriteLine(result);
        }

        private static int GetSpecial(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return 2 * GetSpecial(n - 1) + GetSpecial(n - 2);
        }
    }
}
