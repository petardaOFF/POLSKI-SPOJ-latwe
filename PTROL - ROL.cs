using System;
using System.Collections;
using System.Collections.Generic;

namespace ROL_k_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Queue<string> myQueue = new Queue<string>(Console.ReadLine().Split(' '));
                myQueue.Dequeue();
                var temp = myQueue.Dequeue();
                myQueue.Enqueue(temp);
                foreach (var item in myQueue)
                {
                    Console.Write(item + ' ');


                }Console.WriteLine();
                
            }
            
        }
        
    }
}
