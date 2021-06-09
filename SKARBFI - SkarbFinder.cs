using System;

namespace SKARBFI___SkarbFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] treasure = new int[2];
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    string[] array = Console.ReadLine().Split(' ');
                    string direction = array[0];
                    int steps = int.Parse(array[1]);
                    switch (direction)
                    {
                        case "0":
                            {
                                treasure[0] += steps;

                            }
                            break;
                        case "1":
                            {
                                treasure[0] -= steps;
                            }
                            break;
                        case "2":
                            {
                                treasure[1] += steps;
                            }
                            break;
                        case "3":
                            {
                                treasure[1] -= steps;
                            }
                            break;

                    }

                }
                if (treasure[0] != 0 || treasure[1] !=0)
                {
                    if (treasure[0] > 0)
                    {
                        Console.WriteLine("0 " + treasure[0]);
                    }
                    else if (treasure[0] < 0)
                    {
                        Console.WriteLine("1 " + Math.Abs(treasure[0]));
                    }
                    if (treasure[1] > 0)
                    {
                        Console.WriteLine("2 " + treasure[1]);
                    }
                    else if (treasure[1] < 0)
                    {
                        Console.WriteLine("3 " + Math.Abs(treasure[1]));
                    }

                }
                else
                {
                    Console.WriteLine("studnia");
                }



            }
        }
    }
}
