using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint4.Task4.V11.Lib;

namespace Tyuiu.SmirnovIA.Sprint4.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 5, 7, 7, 8, 5 },
                                          { 6, 5, 6, 8, 6 },
                                          { 7, 6, 8, 8, 5 },
                                          { 7, 6, 7, 8, 6 },
                                          { 7, 6, 7, 7, 5 }};
            int res = ds.Calculate(mas2);
            Assert.AreEqual(81, res);
        }
    }
}
