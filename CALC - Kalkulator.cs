using System;

namespace spoj_calc1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] txt;
            while((txt = Console.ReadLine().Split(' ')) != null)
            {
                int a = int.Parse(txt[1]), b = int.Parse(txt[2]), result=0;
               
                
                switch(txt[0])
                {
                    case "+":
                        {
                            result = a + b;  
                        }
                        break;
                    case "-":
                        {
                            result = a - b;
                        }
                        break;
                    case "*":
                        {
                            result = a * b;
                        }
                        break;
                    case "/":
                        {
                            result = a / b;
                        }
                        break;
                    case "%":
                        {
                            result = a % b;
                        }
                        break;
                }
                Console.WriteLine(result);




            }


        }
    }
}
