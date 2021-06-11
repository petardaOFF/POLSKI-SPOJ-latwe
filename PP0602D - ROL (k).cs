using System;
using System.Collections;
using System.Collections.Generic;

namespace ROL_k_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Magic(Console.ReadLine().Split(' '), Console.ReadLine().Split(' ')));


        }

       static string Magic(string[] howMuch, string[] numbers)
       {
            int k = int.Parse(howMuch[1]);
            string result = "";
            Queue myQueue = new Queue(numbers);

            for (int i = 0; i < k; i++)
            {
                //  var temp = myQueue.Dequeue();
                //myQueue.Enqueue(temp);
                myQueue.Enqueue(myQueue.Dequeue());

            }
            foreach (var item in myQueue)
            {

                result += item + " ";

            }




            return result;
        }
    }

}
