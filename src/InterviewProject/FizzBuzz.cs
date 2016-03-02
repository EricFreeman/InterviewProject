using System;
using System.Text;

namespace InterviewProject
{
    public class FizzBuzz
    {
        /// <summary>
        /// FizzBuzz is a simple program that takes an input and returns one of the following values:
        ///     "Fizz" when the number is divisible by 3
        ///     "Buzz" when the number is divisible by 5
        ///     "FizzBuzz" when the number is divisible by 3 and 5
        ///     The inputed value when none of the above cases are true
        /// </summary>
        public string Execute(int input)
        {
            //     "FizzBuzz" when the number is divisible by 3 and 5
            if ((input % 3 == 0) && (input % 5 == 0))
            {
                return "FizzBuzz";
            }

            //     "Fizz" when the number is divisible by 3
            else if (input%3 == 0)
            {
                return "Fizz";
            }

            //     "Buzz" when the number is divisible by 5
            else if (input%5 == 0)
            {
                return "Buzz";
            }
            //     The inputed value when none of the above cases are true
            else
            {
                return input.ToString(); 
            }
            
        }
    }
}