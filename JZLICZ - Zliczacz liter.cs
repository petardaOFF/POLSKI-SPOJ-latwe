using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] tab = new string[t];
            
            
            for (int i = 0; i < t; i++)
            {

              tab[i] =   Console.ReadLine();
            }

            Console.WriteLine(Magic(tab));

        }
        private static string Magic(string[] txt)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "";

            for (int i = 0; i < alphabet.Length; i++)
            {
                int howMany = 0;
                for (int k = 0; k < txt.Length; k++)
                {
                    for (int j = 0; j < txt[k].Length; j++)
                    {
                       if(txt[k][j]==alphabet[i])
                        {
                            howMany++;
                        }

                     
                    }

                }
              
                

            if(howMany>0)
                {
                    if(alphabet[i]!='Z')
                    {
                        result += alphabet[i] + " " + howMany+"\n";
                    }
                    else
                    {
                        result += alphabet[i] + " " + howMany;
                    }
                    
                   
                }
                howMany = 0;

            }

            return result;
        }
    }
}
