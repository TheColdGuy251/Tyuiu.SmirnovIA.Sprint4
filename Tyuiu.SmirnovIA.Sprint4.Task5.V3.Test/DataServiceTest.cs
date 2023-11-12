using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint4.Task5.V3.Lib;

namespace Tyuiu.SmirnovIA.Sprint4.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -5, 7, 7, 8, 5 },
                                          { 6, 5, 6, 8, 6 },
                                          { 7, 6, -8, 8, -5 },
                                          { 7, 6, 7, 8, 6 },
                                          { -7, 6, 7, 7, 5 }};
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { 0, 7, 7, 8, 5 },
                                          { 6, 5, 6, 8, 6 },
                                          { 7, 6, 0, 8, 0 },
                                          { 7, 6, 7, 8, 6 },
                                          { 0, 6, 7, 7, 5 }};
            CollectionAssert.AreEqual(mas2, res);
        }
    }
}
