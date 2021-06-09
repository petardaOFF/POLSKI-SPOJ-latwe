using System;
using System.Numerics;


namespace JHTMLLET___Tagi_HTML
{
    class Program
    {

        
       
        static void Main(string[] args)
        {


          string text = "";
            



            while((text = Console.ReadLine()) != null)
            {
                string result = "";


                for (int i = 0; i < text.Length; )
                {
                   
                    if (text[i] == '<')
                   {
                       
                        while(text[i] != '>')
                        {
                            result += char.ToUpper(text[i]);
                            i++;


                           
                        }
                   }
                    else
                    {
                        result += text[i];
                        i++;
                    }
                }
                

                Console.WriteLine(result);
                
             
            }
         
        }


    }
       
}
  








