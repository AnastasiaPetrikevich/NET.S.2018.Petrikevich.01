using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Filter.Filter;

namespace Filter.Tests
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void FilterDigit_Array_7_1_2_3_4_5_6_7_68_69_70_15_17_Digit_7_Expected_7_70_17()
        {
            int[] actual = new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int digit = 7;
            actual = FilterDigit(actual, digit);

            int[] expected = { 7, 70, 17 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void FilterDigit_Array_13_Minus8_15_IntMinValue_7_69_88_8_100_IntMaxValue_4_Digit_8_Expected_Minus8_IntMinValue_88_8_IntMaxValue()
        {
            int[] actual = new int[] { 13, 8, 15, int.MinValue, 7, 69, 88, -8, 100, int.MaxValue, -18 };
            int digit = 8;
            actual = FilterDigit(actual, digit);

            int[] expected = { 8, int.MinValue, 88, -8, int.MaxValue,-18 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FilterDigit_ArrayNull_Expected_ArgumentNullException() => FilterDigit(null, 0);

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FilterDigit_Array_10_6_11_ArgumentOutOfRangeException()
        {
            int[] actual = new int[] { 10, 6, 11 };
            int digit = 10;

            FilterDigit(actual,digit);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FilterDigit_ArrayEmpty_ArgumentException()
        {
            int[] actual = new int[] { };
            FilterDigit(actual, 0);
        }

    }
}
