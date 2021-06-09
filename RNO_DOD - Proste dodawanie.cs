using System;

namespace rno_dod_spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(AdditionMethod(int.Parse(Console.ReadLine()), Console.ReadLine()));
            }
        }



        static int AdditionMethod(int howMuch, string w)
        {
            string[] whichOne = w.Split(' ');
            int result=0;


            for (int i = 0; i < whichOne.Length && i < howMuch; i++)
            {
                result += int.Parse(whichOne[i]);  
            }
            
            
           



          
            
            return result;
        }
    }
}
