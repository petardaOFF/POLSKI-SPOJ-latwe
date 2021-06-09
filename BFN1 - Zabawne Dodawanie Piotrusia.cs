using System;

namespace BFN1_spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(Actions(int.Parse(Console.ReadLine())));
            }
               
        }
        static string Actions(int x)
        {
            int counter=0;
            int result = x;
            string textResult = "";


            do
            {
                if (result == Reverse(result.ToString()))
                {
                    textResult = result + " " + counter.ToString();
                    counter = 0;
                    return textResult;
                }
                else
                {

                    
                        result = result + Reverse(result.ToString());
                        counter++;
                    textResult = result + " " + counter.ToString();




                }
               
            } while (result !=Reverse(result.ToString()));
               
            
          

            return textResult;
            
            
        }
      static  int Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            int d = int.Parse(charArray);
            
            return d ;
        }
    }
}
