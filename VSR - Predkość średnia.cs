using System;

namespace VSR
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(Cuter(Console.ReadLine().Split(' ')));

            }
        }
        private static double Cuter(string[] text)
        {
            int a = int.Parse(text[0]);
            int b = int.Parse(text[1]);
            double result;
            if(a<b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            int s = a * 2;
            float T = 1 + (float)a / (float)b;
            result = Math.Round(s / T);



            return result;
                
        }
    }
}
