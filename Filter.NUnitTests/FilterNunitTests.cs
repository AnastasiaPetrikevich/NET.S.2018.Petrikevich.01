using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Filter.Filter;

namespace Filter.NUnitTests
{
    [TestFixture]
    public class FilterNunitTests
    {
        
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        [TestCase(new int[] { 13, 8, 15, int.MinValue, 7, 69, 88, -8, 100, int.MaxValue, -18 }, 8, ExpectedResult =
            new int[] { 8, int.MinValue, 88, -8, int.MaxValue, -18 })]
        public int[] FilterDigit_ResultContainsDigit(int[] array, int digit) => array.FilterDigit( new ContainsDigit(digit));

        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, ExpectedResult = new int[] { 2, 4, 6, 68, 70 })]
        [TestCase(new int[] { 13, 8, 15, int.MinValue, 7, 69, 88, -8, 100, int.MaxValue, -18 }, ExpectedResult =
            new int[] { 8, Int32.MinValue, 88, -8, 100, -18 })]
        public int[] FilterDigit_ResultEvenNumbers(int[] array) => array.FilterDigit(new EvenNumber());

        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, ExpectedResult = new int[] { 7, 1, 3, 5, 7, 69, 15, 17 })]
        [TestCase(new int[] { 13, 8, 15, int.MinValue, 7, 69, 88, -8, 100, int.MaxValue, -18 }, ExpectedResult =
            new int[] { 13, 15, 7, 69, int.MaxValue })]
        public int[] FilterDigit_ResultOddNumbers(int[] array) => array.FilterDigit(new OddNumber());

        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, ExpectedResult = new int[] { 7, 1, 2, 3, 5, 7, 17 })]
        public int[] FilterDigit_ResultSimpleNumbers(int[] array) => array.FilterDigit(new SimpleNumber());

        [TestCase(null)]
        public void FilterDigit_ArrayNull_Throw_ArgumentNullException(int[] array)
            => Assert.Throws<ArgumentNullException>(() => array.FilterDigit(new ContainsDigit(0)));

        [TestCase(new int[]{ })]
        public void FilterDigit_ArrayEmpty_Throw_ArgumentException(int[] array)
            => Assert.Throws<ArgumentException>(() => array.FilterDigit(new ContainsDigit(0)));

        [TestCase(new int[] { 6, 10, 11 })]
        public void FilterDigit_InvalidDigit_Throw_ArgumentOutOfRangeException(int[] array)
            => Assert.Throws<ArgumentOutOfRangeException>(() => array.FilterDigit( new ContainsDigit(10)));

    }
}
