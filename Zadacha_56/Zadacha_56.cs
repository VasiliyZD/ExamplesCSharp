/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
using System;

namespace Zadacha_56
{
    class Zadacha_56
    {
        static  int FindMinSummElem(ref int [, ] a){

            int i, j, min = int.MaxValue , indexMin = 0;
            for(i=0; i < a.GetLength(0); i++)
            {
                int summ = 0;

                //находим минимальный индекс элемента
                for (j = 0; j < a.GetLength(1); j++)
                {
                    summ  = summ + a[i,j];
                }

                //меняем значения местами
                if (summ< min) { 
                    indexMin =  i;
                };
            }
            return indexMin;   
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
                Console.WriteLine($"Индекс строки с минимальной суммой элементов {FindMinSummElem(ref a)}");
                
                


            }
            catch  {
                Console.WriteLine("Вы ввели числа неправильно");
            }
        }
    }
}
