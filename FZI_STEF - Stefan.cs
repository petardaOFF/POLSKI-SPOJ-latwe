using System;

namespace FZI_STEF___Stefan
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int x, w=0, s=0;
            while(t>0)
            {
               x = int.Parse(Console.ReadLine());

                if(w>0)
                {
                    w += x;
                }
                else                //okzalo sie ze nie mozna odsylac w C# ale działa? działa
                {
                    w = x;
                }
                if(w>s)
                {
                    s = w;
                }
                t--;

            }
            Console.WriteLine(s);

        }
    }
}
