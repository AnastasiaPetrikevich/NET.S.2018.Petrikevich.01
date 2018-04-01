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
        /// <param name="predicate">Predicate by which is filtered.</param>
        /// <returns>Filtered array.</returns>
        public static int[] FilterDigit(int[] array, IPredicate predicate)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length <= 0)
            {
                throw new ArgumentException(nameof(array));
            }

            List<int> result = new List<int>();

            foreach (var element in array)
            {
                if (predicate.IsMatch(element))
                    result.Add(element);
            }

            return result.ToArray();
        }

      
    }
}
