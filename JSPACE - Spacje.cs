using System;

namespace JDSSPACE
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            while ((t = Console.ReadLine()) != null)
            {
                string result = "";
                string[] txt = t.Split(' ', '\t');
                for (int i = 1; i < txt.Length; i++)
                {
                    if(txt[i].Length>0)
                    {
                        txt[i] = char.ToUpper(txt[i][0]) + txt[i].Substring(1);
                    }
                  


                }

                foreach (var item in txt)
                {
                    result += item;
                }

               

                Console.WriteLine(result);

            }
        }
        


    }
}
