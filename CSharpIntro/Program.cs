using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //make bool, string, and int variables (with values)
            // variable: a container for a value of some type

            bool b = true;
            string s = "My name is Victoria.";
            int a = 25;



            //change their values to comething else

            b = false;
            s = "My name is not Victoria.";
            a = 26;

            //print their values with  Console

            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(a);


            //do something in a loop
            int counter = 0;
            while (counter < 5)

            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }


            //do something in a while loop

            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 5);

            //do something in a for loop

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }


            //do something with a switch statement
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }
            //do something with if, else if, else

            if (caseSwitch == 1)
            {
                Console.WriteLine("This is case 1");
            }
            else if (caseSwitch == 2)
            {
                Console.WriteLine("This is case 2.");
            }
            else
            {
                Console.WriteLine("This is an unknown case");


            }




            //figure out how to make multi-line comments in C#

            /*this
            is multi
            line */


            //figure out how to format your document in VS code

            //extra: make a new static methods to do something and call it

            

            //extra: learn what "var" means in C# and try it out



        }
    }
}
