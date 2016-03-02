using System;
using System.Linq;

namespace InterviewProject
{
    public class LargestProductInSeries
    {
        /// <summary>
        /// For the provided series of digits, find the largest product of three consecutive digits.
        /// 
        /// Input will be a string looking something like: "093824840"
        /// Result would be the largest product of three consecutive digits (in this case 216 which is 9 * 3 * 8)
        /// </summary>
        public int Execute(string series)
        {
            int largest = 0;

            // parse string
            var seriesDigits = series.ToCharArray(0, series.Length).Select(x=>int.Parse(x.ToString())).ToArray();
            for (int i = 0; i < series.Length - 2; i++)
            {
                int one = seriesDigits[0 + i];
                int two = seriesDigits[1 + i];
                int three = seriesDigits[2 + i];

                int product = one*two*three;

                if (product > largest)
                {
                    largest = product;
                }
            }

            // calculate product and check if largest

            return largest;
        }
    }
}