/*
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

using System;

namespace EulerP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToTest = 20;
            bool numFound = false;

            while (numFound == false)
            {
                // start loop at 2 because everything divides evenly by 1
                for (int i = 2; i < 21; i++)
                {
                    // if the number doesn't divide evenly, break out the loop immediately
                    if (numToTest % i != 0)
                    {
                        break;
                    }

                    // if the number divides evenly by 20 and we're on the last iteration, we know this number divides evenly by all numbers up to 20
                    // break out the for loop
                    if (numToTest % i == 0 && i == 20)
                    {
                        numFound = true;
                        break;
                    }
                }

                // if the number hasn't been found after the for loop has been exited, increment the number by 20
                if (numFound == false)
                {
                    numToTest += 20;
                }
            }

            Console.WriteLine($"The smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is: {numToTest}");
        }
    }
}
