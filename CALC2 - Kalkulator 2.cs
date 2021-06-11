using System;

namespace spoj_calc1
{
    class Program
    {
        static void Main(string[] args)
        {


           
            string text;
            int[] cache = new int[10];
            while ((text = Console.ReadLine()) != null)
            {
                string[] txt = text.Split(' ');


                int a = int.Parse(txt[1]);
                int b = int.Parse(txt[2]);

                switch (txt[0])
                {
                    case "+":
                        {
                            Console.WriteLine(cache[a] + cache[b]);

                        }
                        break;

                    case "-":
                        {
                            Console.WriteLine(cache[a] - cache[b]);
                        }
                        break;

                    case "*":
                        {
                            Console.WriteLine(cache[a] * cache[b]);
                        }
                        break;

                    case "/":
                        {
                            Console.WriteLine(cache[a] / cache[b]);
                        }
                        break;

                    case "%":
                        {
                            Console.WriteLine(cache[a] % cache[b]);
                        }
                        break;
                    case "z":
                        {
                            cache[a] = b;

                        }
                        break;


                }
                
                  
                
             




            }
        }
    }
}
