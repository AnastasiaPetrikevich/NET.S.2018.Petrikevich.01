using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    /// <summary> 
    /// Contains methods for filtering an array.
    /// </summary>
    public static class Filter
    {
        /// <summary>
        /// Filters an array by digit.
        /// </summary>
        /// <param name="array">Array to filter.</param>
        /// <param name="digit">Digit by which is filtered.</param>
        /// <returns>Filtered array.</returns>
        public static int[] FilterDigit(int[] array, int digit)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length <= 0)
            {
                throw new ArgumentException(nameof(array));
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            List<int> result = new List<int>();

            foreach (var element in array)
            {
                if (IsContainsDigit(element, digit))
                    result.Add(element);
            }

            return result.ToArray();
        }



        /// <summary>
        /// Check if the digit contains in the number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <param name="digit">Digit which must be contains in the number</param>
        /// <returns>Return true if the digit contains in the number and false if not.</returns>
        public static bool IsContainsDigit(int number, int digit)
        {
            while (number != 0)
            {
                if (number % 10 == digit || number % 10 == -digit)
                    return true;
                number = number / 10;
            }
            return false;
        }
    }
}
