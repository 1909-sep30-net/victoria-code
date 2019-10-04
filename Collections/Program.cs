using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays();
            Lists();
        }

        static void Arrays()
        {
            //Arrays are the most basic way
            // to group many values of the same type together
            int[] intArray = new int[4]; //all entries intialized to default 0
            //arrays are fixed-size from once they are created
            intArray[0] = 3;
            intArray[1] = 5;
            // now array looks like 3, 5, 0, 0.

            //software called "debugger"
            //"breakpoint" where to stop, click on the left until a red circle appears

            //this type of syntax is called "collection initializer"
            int[] intArray2 = new int[] { 1, 2, 3, 4, 12 }; //inferred to be size 5
            Console.WriteLine("Enter a length.");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            int [] array3 = new int[length];


            int[][] twoD = new int[3][];
            twoD[0] = new int[] { 1, 2 };
            twoD[1] = new int[] {1, 2, 3};


            int[,] twoDMulti = new int [3,5];

         }
    }
}


