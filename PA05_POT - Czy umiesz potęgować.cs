using System;


namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int D = int.Parse(Console.ReadLine());
            for (int i = 0; i < D; i++)
            {
     
              Console.WriteLine(ResultMethod(Console.ReadLine()));
            }
         
        }

        static int ResultMethod(string s)
        {
            string[] numbers = s.Split(' ');
            int a = int.Parse(numbers[0])%10;
            int b = int.Parse(numbers[1]);
            int wynik = a;
            if(b%4==0)
            {
                b = 4;
            }
            else
            {
                b %= 4;
            }
            for (int i = 1; i < b; i++)
            {
                wynik *= a;
            }
           
           
           

            return wynik%10; 
        }
      
    }
}
