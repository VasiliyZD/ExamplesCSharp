/*
Задача HARD SORT.

Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

Например, задан массив:
1 4 7 2
5 9 10 3

После сортировки
1 2 3 4
5 7 9 10
*/
using System;

namespace HardSort
{
    class HardSort
    {
        static  void  SampleSort(ref int [] a){

            int i, j, min, temp;
            for(i=0; i < a.Length - 1; i++)
            {
                min = i; //устанавливаем начальное значение минимального индекса
                
                //находим минимальный индекс элемента
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                        min = j;
                }

                //меняем значения местами
                temp = a[i];
                a[i] = a[min];
                a[min] = temp;
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

        static int[] Array2D_1D(ref int[,] a){
            int[] res = new int [a.GetLength(0)*a.GetLength(1)];    
            int z = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        res[z] = a[i, j];
                        z++;
                    } 
            return res;
        }    
        static int[,] Array1D_2D(ref int[] a, int columns, int rows){
            int[,] res = new int [rows, columns];    

            int z = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    res[i, j] = a[z++];
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
                int [] m = Array2D_1D(ref a);
                SampleSort(ref m);
                a =  Array1D_2D(ref m, (int) columns, (int) rows);
                Console.WriteLine("Отсортированный массив: ");
                PrintArray(a);


            }
            catch{
                Console.WriteLine("Вы ввели числа неправильно");
            }
        }
    }
}
