using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ArraySorts.Sorts;

namespace ArraySorts.Tests
{
    [TestClass]
    public class SortsTests
    {
        [TestMethod]
        public void QuickSort_Array_3_7_2_5_Expected_2_3_5_7()
        {
            int[] actual = new int[] { 3, 7, 2, 5 };
            int[] expected = new int[] { 2, 3, 5, 7 };
            QuickSort(actual);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void QuickSort_Array_34_9_21_Minus5_Minus7_103_0_Expected_Minus7_Minus5_0_9_21_34_103()
        {
            int[] actual = new int[] { 34, 9, 21, -5, -7, 103, 0 };
            int[] expected = new int[] { -7, -5, 0, 9, 21, 34, 103 };
            QuickSort(actual);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void QuickSort_Array_29_Minus2_IntMinValue_Minus15_IntMaxValue_10_Expected__IntMinValue_Minus15_Minus2_10_29_IntMaxValue()
        {
            int[] actual = new int[] { 29, -2, int.MinValue, -15, int.MaxValue, 10 };
            int[] expected = new int[] { int.MinValue, -15, -2, 10, 29, int.MaxValue };
            QuickSort(actual);
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_ArrayNull_ArgumentNullException() => QuickSort(null);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void QuickSort_ArrayEmpty_ArgumentException()
        {
            int[] actual = new int[] { };
            QuickSort(actual);
        }


        [TestMethod]
        public void MergeSort_Array_3_7_2_5_Expected_2_3_5_7()
        {
            int[] actual = new int[] { 3, 7, 2, 5 };
            int[] expected = new int[] { 2, 3, 5, 7 };
            MergeSort(actual);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void MergeSort_Array_34_9_21_Minus5_Minus7_103_0_Expected_Minus7_Minus5_0_9_21_34_103()
        {
            int[] actual = new int[] { 34, 9, 21, -5, -7, 103, 0 };
            int[] expected = new int[] { -7, -5, 0, 9, 21, 34, 103 };
            MergeSort(actual);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void MergeSort_Array_29_Minus2_IntMinValue_Minus15_IntMaxValue_10_Expected__IntMinValue_Minus15_Minus2_10_29_IntMaxValue()
        {
            int[] actual = new int[] { 29, -2, int.MinValue, -15, int.MaxValue, 10 };
            int[] expected = new int[] { int.MinValue, -15, -2, 10, 29, int.MaxValue };
            MergeSort(actual);
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSort_ArrayNull_ArgumentNullException() => MergeSort(null);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MergeSort_ArrayEmpty_ArgumentException()
        {
            int[] actual = new int[] { };
            MergeSort(actual);
        }

    }
}
