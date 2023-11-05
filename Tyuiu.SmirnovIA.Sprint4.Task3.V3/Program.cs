using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SmirnovIA.Sprint4.Task3.V3.Lib;

namespace Tyuiu.SmirnovIA.Sprint4.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] { { 9, 4, 5, 4, 8 },
                                          { 7, 6, 7, 7, 4 },
                                          { 4, 4, 3, 5, 6 },
                                          { 6, 5, 9, 4, 9 },
                                          { 9, 7, 8, 7, 7 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Смирнов И. А. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Смирнов Илья Алексеевич | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* 9, 4, 5, 4, 8,                                                          *");
            Console.WriteLine("* 7, 6, 7, 7, 4,                                                          *");
            Console.WriteLine("* 4, 4, 3, 5, 6,                                                          *");
            Console.WriteLine("* 6, 5, 9, 4, 9,                                                          *");
            Console.WriteLine("* 9, 7, 8, 7, 7,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Количество нечётных элементов = " + ds.Calculate(mtrx));

            Console.ReadKey();
        }
    }
}
