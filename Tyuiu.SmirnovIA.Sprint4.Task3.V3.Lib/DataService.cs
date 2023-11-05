using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SmirnovIA.Sprint4.Task3.V3.Lib
{
    public class DataService : ISprint4Task3V3
    {
        public int Calculate(int[,] array)
        {
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}
