using System;
using System.Collections.Generic;

namespace spoj_systemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string d = Console.ReadLine();


                Console.WriteLine(To16(d) + " " + To11(d));

            }
        }
        private static string To16(string txt)
        {
            int resultInt = int.Parse(txt);


            int i = 0;
            List<int> rest = new List<int>();


            while (resultInt > 0)
            {
                rest.Add(resultInt % 16);
                resultInt /= 16;

                i++;

            };

            List<string> list = rest.ConvertAll(delegate (int z) { return z.ToString(); });


            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] == "10")
                {
                    list[j] = "A";
                }
                else if (list[j] == "11")
                {
                    list[j] = "B";
                }
                else if (list[j] == "12")
                {
                    list[j] = "C";
                }
                else if (list[j] == "13")
                {
                    list[j] = "D";
                }
                else if (list[j] == "14")
                {
                    list[j] = "E";
                }
                else if (list[j] == "15")
                {
                    list[j] = "F";
                }
            }
            string resultString = "";
            for (int j = list.Count - 1; j >= 0; j--)
            {
                resultString += list[j];
            }


            return resultString;
        }
        private static string To11(string txt)
        {
            int resultInt = int.Parse(txt);

           
            List<int> rest = new List<int>();



            while (resultInt > 0)
            {
                rest.Add(resultInt % 11);
                resultInt /= 11;
              
            };

            List<string> list = rest.ConvertAll(delegate (int k) { return k.ToString(); });

            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] == "10")
                {
                    list[j] = "A";
                }

            }
            string resultString = "";
            for (int j = list.Count - 1; j >= 0; j--)
            {
                resultString += list[j];
            }


            return resultString;
        }
      
    }
}
