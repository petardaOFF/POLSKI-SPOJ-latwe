using System;

namespace SPOJ_FLAMASTER
{
    class Program
    {
        static void Main(string[] args)
        {

            int C = int.Parse(Console.ReadLine());

            for (int i = 0; i < C; i++)
            {
               Console.WriteLine(StringReplacer(Console.ReadLine()));
            }
            
        }


        static string StringReplacer(string text)
        {
            string result="";
            char curretChar;
            int j=0, howMany=0;
          
            while (j<text.Length)
            {
                curretChar = text[j];

                howMany = 0;
              
                for (; j < text.Length && text[j]==curretChar; j++)
                {
                    howMany++;
                }
                if(howMany==1)
                {
                    result += curretChar.ToString();

                }
                else if(howMany == 2)
                {
                    result += curretChar.ToString();
                    result += curretChar.ToString();
                }
                else
                {
                    result += curretChar.ToString();
                    result += howMany.ToString();
                }


            }
            
           
            
            
            return result;
        }
    }
}
