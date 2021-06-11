using System;

namespace pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(PeselCheck(Console.ReadLine()));

            }
        }
        private static string PeselCheck(string txt)
        {
            int[] product = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            int result_a=0;
            int result_b=0;
            for (int i = 0; i < 11; i++)
            {

                result_a = txt[i] * product[i];
                result_b += result_a;
            }


            if (result_b > 0 && result_b%10==0)
            {
               
                
                    return "D";
           }
            else
                return "N";
            
        }
    }
}
