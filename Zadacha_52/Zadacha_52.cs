/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/
using System;

namespace Zadacha_52
{
    class Zadacha_52
    {
        static int [,] rndArr(uint rows, uint col){
                int[,] a = new int[rows, col];
                const int rangeMax = 100;
                Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = random.Next(0, rangeMax)  ;//Числа в диапазоне от 0 до rangeMax от 0 до 100
                }
            }
            return a;
        }
        static void PrintArray(int [,] a){
            for (int i = 0; i < a.GetLength(0); i++)
            {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            Console.Write(a[i, j] + "\t");
                           
                        }
                        Console.WriteLine();
            }
        }

        static void Print1DArray(double [] a){
            for (int i = 0; i < a.Length; i++)
            {
                            Console.Write(a[i] + ";\t");
                           
            }
            Console.WriteLine();
        }
 
        static double [] Mean(int [,] a){
            double [] res = new double [a.GetLength(0)] ;
            for (int i = 0; i < a.GetLength(0); i++)
            {
            double summ = 0;
            double mean;    
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            summ = summ + a[i,j];
                        }
                        mean = summ / a.GetLength(1);
                        res[i] = mean;
            }
            return res;
        }


        static void Main(string[] args)
        {
            uint rows = 3;
            uint columns = 4;
            try {
                Console.WriteLine("Введите число строк и столбцов таблицы: ");
                Console.Write("Введите число строк таблицы: ");
                rows = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите число столбцов таблицы: ");
                columns = UInt32.Parse(Console.ReadLine());

                int[,] a = rndArr(rows, columns);
                PrintArray(a);
                double [] m =  Mean(a);
                Console.Write("Среднее арифметическое: ");
                Print1DArray(m);


            }
            catch{
                Console.WriteLine("Вы ввели числа неправильно");
            }

        }
    }
}