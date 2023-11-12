using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.SmirnovIA.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 5; int cols = 3;
            int[,] mtrx = new int[rows, cols];
            string str = "351268459614723";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, cols, str);
            Assert.AreEqual(18432, res);
        }
    }
}
