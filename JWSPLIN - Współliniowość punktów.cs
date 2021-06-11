using System;

namespace wspoliiowosc_pkt
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
          
            for (int i = 0; i < t; i++)
            {
               Console.WriteLine(TripleS(Console.ReadLine().Split('\t')));



            }
        }
       private static string TripleS(string[] txt)
        {
           double a11 = double.Parse(txt[0]), a12 = double.Parse(txt[1]), a21 = double.Parse(txt[2]), a22 = double.Parse(txt[3]), a31= double.Parse(txt[4]), a32= double.Parse(txt[5]);
          

          
            double result = a11 * a22 + a12 * a31 + a21 * a32 - (a22 * a31 + a11 * a32 + a12 * a21);
          

            if(result==0)
            {
                return "TAK";
            }
            else
            {
                return "NIE";
            }

        }
    }
}
