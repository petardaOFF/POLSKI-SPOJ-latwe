using System;

namespace no
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            
            int result=0;
            while((a=Console.ReadLine()) !=null)
            {
                Console.WriteLine(result += int.Parse(a));
            }
            
        }
    }
}
