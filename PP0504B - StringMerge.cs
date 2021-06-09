using System;

namespace PP0504B___StringMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] words = Console.ReadLine().Split(' ');

                Console.WriteLine(StringCreator(words[0], words[1]));
            }
        }
        static string StringCreator(string a, string b)
        {
            string result = "";
            int lenght = a.Length < b.Length ? a.Length : b.Length;

            for (int i = 0; i < lenght; i++)
            {
                result += a[i];
                result += b[i];

            }

            return result;
        }
    }
}
