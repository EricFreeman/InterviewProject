using System;

namespace InterviewProject
{
    public class EvenFibonacciNumbersSum
    {
        /// <summary>
        /// Calculate the sum of every even Fibonacci number from 0 to upperLimit
        /// 
        /// A Fibonacci sequence is a list of numbers where the digit is the sum of the previous two digits.
        /// For example, it would look like this: [0, 1, 1, 2, 3, 5, 8, 13, 21, ...]
        /// 
        /// upperLimit is the max value that can be in the Fibonacci sequence
        /// </summary>
        public int Execute(int upperLimit)
        {
            int i = 0;
            int j = 1;
            //int fib = 1;
            int sum = 0;

            // calculate Fibonacci sequence
            // sum even numbers up to given upperLimit
            do
            {
                if (j % 2 == 0)
                {
                    sum += j;
                }

                int temp = j;
                j = nextFib(i, j);
                i = temp;

            } while (j <= upperLimit);

            return sum;
        }

        // recursive function to calculate next number in Fibonacci sequence
        int nextFib(int prevFib1, int prevFib2)
        {
            return prevFib1 + prevFib2;
        }
    }
}