using System;

namespace bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i <t; i++)
            {
                string text = ToBytes(float.Parse(Console.ReadLine()));
                string result = AdvandcedReverse(text);
                Console.WriteLine(result.ToLower());



            }


        }
        private static string AdvandcedReverse(string t)
        {
            string result = "";
            string[] txt = t.Split("-");

            for(int i = txt.Length-1; i >=0; i--)
            {
                
                if(txt[i][0]=='0')
                {
                    result += txt[i][1];
                }
                else
                {
                    result += txt[i];
                }
                if(i>0)
                {
                    result += " ";
                }
                
                
               
            }



            return result;
        }

        static string ToBytes(float v) => BitConverter.ToString(BitConverter.GetBytes(v));








    }
}
