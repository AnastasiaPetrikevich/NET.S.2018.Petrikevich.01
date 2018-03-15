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

            for (int i = 0; i < array.Length; i++)
            {
                if (DigitContain(array[i], digit) && !result.Contains(array[i]))
                {
                    result.Add(array[i]);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Check if the digit contains in the number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <param name="digit">Digit which must be contains in the number</param>
        /// <returns>Return true if the digit contains in the number and false if not.</returns>
        public static bool DigitContain(int number, int digit)
        {
            if (number.ToString().Contains(digit.ToString()))
            {
                return true;
            }

            return false;
        }
    }
}
