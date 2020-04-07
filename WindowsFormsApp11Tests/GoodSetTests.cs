using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.Tests
{
    [TestClass()]
    public class GoodSetTests
    {
        [TestMethod()]
        public void SetUnionTest()
        {
            int[] firstSet = { 0, 1, 2, 3, 4 };
            int[] secondSet = { 4, 5, 6 };
            GoodSet first = new GoodSet(firstSet);
            GoodSet second = new GoodSet(secondSet);

            var resSet = first + second;

            int[] resArray = { 0, 1, 2, 3, 4, 5, 6 };

            GoodSet res = new GoodSet(resArray);
            Assert.AreEqual(resSet, res);
        }

        [TestMethod()]
        public void SetIntersectionTest()
        {
            int[] firstSet = { 0, 1, 2, 3, 6 };
            int[] secondSet = { 1, 2, 4, 5, 6};
            GoodSet first = new GoodSet(firstSet);
            GoodSet second = new GoodSet(secondSet);

            var resSet = first * second;

            int[] resArray = { 1, 2, 6 };

            GoodSet res = new GoodSet(resArray);
            Assert.AreEqual(resSet, res);
        }

        [TestMethod()]
        public void SetDifferenceTest()
        {
            int[] firstSet = { 0, 1, 2, 3 };
            int[] secondSet = { 1, 2, 4, 5, 8 };
            GoodSet first = new GoodSet(firstSet);
            GoodSet second = new GoodSet(secondSet);

            var resSet = first - second;

            int[] resArray = { 0, 3, 4, 5, 8 };

            GoodSet res = new GoodSet(resArray);
            Assert.AreEqual(resSet, res);
        }

        [TestMethod()]
        public void SetAddTest()
        {
            int num = 9;
            int[] firstSet = { 0, 1, 2, 3, 4, 6 };
            GoodSet first = new GoodSet(firstSet);

            var resSet = first + num;

            int[] resArray = { 0, 1, 2, 3, 4, 6, 9 };

            GoodSet res = new GoodSet(resArray);
            Assert.AreEqual(resSet, res);
        }

        [TestMethod()]
        public void SetRemoveTest()
        {
            int num = 7;
            int[] firstSet = { 0, 1, 2, 3, 7, 8 };
            GoodSet first = new GoodSet(firstSet);

            var resSet =  num - first;

            int[] resArray = { 0, 1, 2, 3, 8 };

            GoodSet res = new GoodSet(resArray);
            Assert.AreEqual(resSet, res);
        }
    }
}