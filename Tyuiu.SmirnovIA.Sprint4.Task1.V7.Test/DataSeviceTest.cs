using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint4.Task1.V7.Lib;

namespace Tyuiu.SmirnovIA.Sprint4.Task1.V7.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            int res = ds.Calculate(array);
            Assert.AreEqual(24, res);
        }
    }
}
