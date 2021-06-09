using System;

namespace PP0501A_spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(nwd(Console.ReadLine()));
                
            }
        }
        static int nwd(string str)
        {

            string[] numbers = str.Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            while(a != b)
            {
                if(a>b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            
            
            
            
            
            return a;
        }
    }
}
