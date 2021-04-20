using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] Array = new int[10];
            //int[] Array = new int[10] {4,2,7,8,4,232,7,4,8,1};


            //get user input for aray
           for (int i = 0; i < 10; i++)
           {
               string t1 = Console.ReadLine();
               int t2 = Convert.ToInt32(t1);
           
               Array[i] = t2;
           }

           //print array method
            PrintSeq(Array);

            //loop through array 10 passthroughs unless there has been no swaps in code
            for (int j = 0; j < Array.Length; j++)
            {
                //start of each passthrough initialise swaps
                int swaps = 0;
                //itterate through dataset swapping numbers if left one is larger until there are no swaps.
                for (int i = 0; i < Array.Length - 1; i++)
                {

                    if (Array[i] > Array[i + 1])
                    {
                        int temp = 0;
                        temp = Array[i];
                        Array[i] = Array[i + 1];
                        Array[i + 1] = temp;
                        swaps++;
                    }

                    PrintSeq(Array);
                }
                Console.WriteLine("Swaps: " + swaps);

                //escape loop if there were no swaps that passthrough
                if (swaps == 0)
                {
                    break;
                }
            }

            Console.ReadLine();

        }

        public static void PrintSeq(int[] Array)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Array[i]);
                Console.Write(",");
            }
            Console.WriteLine("");
        }

    }
}
