using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SmirnovIA.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }

            int mult = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   if (mtrx[i, j] % 2 == 0)
                    {
                        mult *= mtrx[i, j];
                    }
                }
            }
            return mult;
        }
    }
}
