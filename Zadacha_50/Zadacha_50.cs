/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
using System;

namespace Zadacha_50
{
    class Zadacha_50
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
        static bool findElem(int [,] a, int e, out int row, out int col){
            bool res = false; 
            row = -1;
            col = -1;   
            for (int i = 0; i < a.GetLength(0); i++)
            {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            res = (a[i,j] == e);
                            if (res) {
                                row = i;
                                col = j;
                                return res;
                            };
                            
                        }
                        
            }
            return res;
        }


        static void Main(string[] args)
        {
            uint rows = 3;
            uint columns = 4;
            int element = 10; 
            int row = -1;
            int col = -1;
            try {
                Console.WriteLine("Введите число строк и столбцов таблицы: ");
                Console.Write("Введите число строк таблицы: ");
                rows = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите число столбцов таблицы: ");
                columns = UInt32.Parse(Console.ReadLine());

                int[,] a = rndArr(rows, columns);
                PrintArray(a);
                Console.Write("Введите элемент который нужно найти в таблице, и мы выведем его позицию - строку и колонку: ");
                element = Int32.Parse(Console.ReadLine());
                if (findElem(a, element, out row, out col)){
                       Console.WriteLine($"Элемент {element} найден в позиции: [{row}, {col}]");
                }else{
                       Console.WriteLine("Такого элемента нет");
                }
                ;


            }
            catch{
                Console.Write("Вы ввели числа неправильно");
            }

        }
    }
}
