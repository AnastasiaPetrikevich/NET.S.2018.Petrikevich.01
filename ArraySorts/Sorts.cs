using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorts
{
    /// <summary>
    /// The ArraySorts class contains methods for sorting an array.
    /// </summary>
    public static class Sorts
    {
        /// <summary>
        /// Sorts an array causing QuickSort with three parameters.
        /// </summary>
        /// <param name="array">Array which you want to sort.</param>
        public static void QuickSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length <= 0)
            {
                throw new ArgumentException(nameof(array));
            }

            if (array.Length == 1)
            {
                return;
            }

            QuickSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Sorts an array using a method Sort.
        /// </summary>
        /// <param name="array">Array which you want to sort.</param>
        public static void MergeSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length <= 0)
            {
                throw new ArgumentException(nameof(array));
            }

            if (array.Length == 1)
            {
                return;
            }

            Array.Copy(Sort(array), array, array.Length);
        }

        /// <summary>
        /// Sorts a left and a right part of the array relative to a pont.
        /// </summary>
        /// <param name="array">Array which  you want to sort.</param>
        /// <param name="left">pointer to an element to the left side of the point.</param>
        /// <param name="right">pointer to an element to the right side of the point.</param>
        private static void QuickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int point = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i] < point)
                {
                    i++;
                }

                while (array[j] > point)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(array, left, j);
            }

            if (right > i)
            {
                QuickSort(array, i, right);
            }
        }

        /// <summary>
        /// Sorts an array using a method Merge.
        /// </summary>
        /// <param name="array">Array which you want to sort.</param>
        /// <returns>Sorted array.</returns>
        private static int[] Sort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int midle = array.Length / 2;
            return Merge(Sort(array.Take(midle).ToArray()), Sort(array.Skip(midle).ToArray()));
        }

        /// <summary>
        /// Connect two arrays in one.
        /// </summary>
        /// <param name="firstArray">First of two arrays.</param>
        /// <param name="secondArray">Second of two arrays.</param>
        /// <returns>Sorted array.</returns>
        private static int[] Merge(int[] firstArray, int[] secondArray)
        {
            int right = 0;
            int left = 0;
            int[] merged = new int[firstArray.Length + secondArray.Length];

            for (int i = 0; i < firstArray.Length + secondArray.Length; i++)
            {
                if (right < secondArray.Length && left < firstArray.Length)
                {
                    if (firstArray[left] > secondArray[right])
                    {
                        merged[i] = secondArray[right++];
                    }
                    else
                    {
                        merged[i] = firstArray[left++];
                    }
                }
                else
                {
                    if (right < secondArray.Length)
                    {
                        merged[i] = secondArray[right++];
                    }
                    else
                    {
                        merged[i] = firstArray[left++];
                    }
                }
            }

            return merged;
        }
    }
}
