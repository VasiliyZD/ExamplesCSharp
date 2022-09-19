/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
using System;


namespace Zadacha_47
{
    class Zadacha_47
    {
        static double [,] rndArr(uint rows, uint col){
                double[,] a = new double[rows, col];
                const double rangeMax = 10.0;
                Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = (random.NextDouble()-0.5)*rangeMax  ;//Числа в диапазоне от -rangeMax до rangeMax от -10.0 до 10.0
                }
            }
            return a;
        }
        static void PrintArray(double [,] a){
            for (int i = 0; i < a.GetLength(0); i++)
            {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            Console.Write(a[i, j] + "\t");
                           
                        }
                        Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            uint rows = 3;
            uint col = 4;
            try {
                Console.WriteLine("Введите число строк и столбцов таблицы: ");
                Console.Write("Введите число строк таблицы: ");
                rows = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите число столбцов таблицы: ");
                col = UInt32.Parse(Console.ReadLine());

            double[,] a = rndArr(rows, col);
            PrintArray(a);
            }
            catch{
                Console.Write("Вы ввели числа неправильно");
            }

        }
    }
}
