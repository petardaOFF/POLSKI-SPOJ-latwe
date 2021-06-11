using System;

namespace sdsa
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(Magic(Console.ReadLine().Split(' ')));
                

            }
            
        }
        private static float Magic(string[] txt)
        {
            int[] tab=new int[txt.Length];
            float avarage=0;
           
            for (int i = 1; i < txt.Length; i++)
            {
                tab[i] = int.Parse(txt[i]);
                avarage += tab[i];
            }
            avarage /= tab.Length-1;
            int nearest=0;
            for (int i = 1; i < tab.Length-1; i++)
            {
                if(Math.Abs(avarage-tab[i])<MathF.Abs(avarage-nearest))
                {
                    nearest = tab[i];
                }
            }
            
            return nearest;
        }
    }
}
