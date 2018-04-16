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
        public static IEnumerable<T> FilterDigit<T>(this T[] array, Func<T,bool> predicate)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            if (array.Length <= 0)
            {
                throw new ArgumentException(nameof(array));
            }

            foreach (var element in array)
            {
                if (predicate(element))
                {
                    yield return element;
                }
            }
        }


        /// <summary>
        /// Filters an array by digit.
        /// </summary>
        /// <param name="array">Array to filter.</param>
        /// <param name="predicate">Predicate by which is filtered.</param>
        /// <returns>Filtered array.</returns>
        public static IEnumerable<T> FilterDigit<T>(this T[] array, IPredicate<T> predicate)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            if (array.Length <= 0)
            {
                throw new ArgumentException(nameof(array));
            }

            return array.FilterDigit(predicate.IsMatch);
        }

      
    }
}
