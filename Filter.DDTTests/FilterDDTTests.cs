using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Filter.Filter;

namespace Filter.DDTTests
{
    [TestClass]
    public class FilterDdtTests
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\FilterCases.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Filter.DDTTests\\FilterCases.xml")]
        [TestMethod]
        public void FilterDigit_CasesFromXMLFile()
        {
            var temp = Convert.ToString(TestContext.DataRow["Array"]).Split(new Char[] {' '});
            List<int> actual= new List<int>();
            for (int i = 0; i < temp.Length; i++)
            {
                actual.Add(Convert.ToInt32(temp[i]));
            }
            var digit = Convert.ToInt32(TestContext.DataRow["Digit"]);
            int[] array = new int[] { };
            array=FilterDigit(actual.ToArray(),digit);

            temp = Convert.ToString(TestContext.DataRow["ExpectedResult"]).Split(new Char[] { ' ' });
            List<int> expected = new List<int>();
            for (int i = 0; i < temp.Length; i++)
            {
                expected.Add(Convert.ToInt32(temp[i]));
            }

            CollectionAssert.AreEqual(array,expected.ToArray());
        }
    }
}
