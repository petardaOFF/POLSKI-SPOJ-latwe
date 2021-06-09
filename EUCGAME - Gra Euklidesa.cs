using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);

               while(a !=b)
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
                Console.WriteLine(b+a);


            }
				
		}
    }
}




