using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //DONECreate a variable of type int and initialize the variable with a value of 0
            int num = 0;


            // DONECreate a do-while loop
            do
            {
                //DONE Increment your variable by 1
                num++;
                //DONE Then add your variable to "numbers"
                numbers.Add(num);
            } while (num < 100);
            // DONEWhile your variable is less than 100



            //DONE Create a while loop
            //DONE While your variable is less than 200
            while(num < 200)
            {
                //DONE Increment your variable by 1
                num++;
                //DONE Then add your variable to "numbers"
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //DONE Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");




            //DONE Create a for loop
            //DONE in your initializer set the value of i to 199
            //DONE in your conditional, as long as i is less than or equal to the length of "numbers"
            //DONE and as long as i is greater than or equal to 0
            //DONE Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {    Console.WriteLine(numbers[i]);
            
                // Write to the console "numbers" at index i
            }
        }
    }
}
