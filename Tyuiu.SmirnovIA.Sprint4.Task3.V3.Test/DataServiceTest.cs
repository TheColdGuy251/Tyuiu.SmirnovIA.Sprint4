using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint4.Task3.V3.Lib;

namespace Tyuiu.SmirnovIA.Sprint4.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 9, 4, 5, 4, 8 },
                                          { 7, 6, 7, 7, 4 },
                                          { 4, 4, 3, 5, 6 },
                                          { 6, 5, 9, 4, 9 },
                                          { 9, 7, 8, 7, 7 } };
            int res = ds.Calculate(mas2);
            Assert.AreEqual(14, res);
        }
    }
}
