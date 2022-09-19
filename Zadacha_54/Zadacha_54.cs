/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
using System;

namespace Zadacha_54
{
    class Zadacha_54
    {
        static  void  SimpleSort(ref int [, ] a, int row){

            int i, j, max, temp;
            for(i=0; i < a.GetLength(1) - 1; i++)
            {
                max = i; //устанавливаем начальное значение минимального индекса
                
                //находим минимальный индекс элемента
                for (j = i + 1; j < a.GetLength(1); j++)
                {
                    if (a[row, j] > a[row, max])
                        max = j;
                }

                //меняем значения местами
                temp = a[row, i];
                a[row, i] = a[row, max];
                a[row, max] = temp;
            }
            
        }

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
                for (int i = 0; i < rows; i++) SimpleSort(ref a, i);
                
                Console.WriteLine("Отсортированный массив: ");
                PrintArray(a);


            }
            catch  {
                Console.WriteLine("Вы ввели числа неправильно");
            }
        }
    }
}
