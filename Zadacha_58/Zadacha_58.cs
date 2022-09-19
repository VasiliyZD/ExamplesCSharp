
using System;

namespace Zadacha_58
{

    class Zadacha_58
        {
    

        static int [,] rndArr(uint rows, uint col){
            int[,] a = new int[rows, col];
            const int rangeMax = 100;
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = random.Next(-rangeMax, rangeMax)  ;//Числа в диапазоне от 0 до rangeMax от 0 до 100
                }
            }
            return a;
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
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
            uint rows1 = 3;
            uint columns1 = 4;
            uint rows2 = 4;
            uint columns2 = 3;
            
            try {
                Console.WriteLine("Введите число строк и столбцов матриц для умножения: ");
                Console.Write("Введите число строк матрицы 1: ");
                rows1 = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите число столбцов Матрицы 1: ");
                columns1 = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите число строк матрицы 2: ");
                rows2 = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите число столбцов Матрицы 2: ");
                columns2 = UInt32.Parse(Console.ReadLine());

                int[,] A = rndArr(rows1, columns1);
                int[,] B = rndArr(rows2, columns2);
                Console.WriteLine("Матрица 1: ");
                PrintArray(A);
                Console.WriteLine("Матрица 2: ");
                PrintArray(B);
            
            if (A.GetLength(1) == B.GetLength(0))
            {
                int[,] C = Multiplication(A, B);
                Console.WriteLine("Результат A x B");
                PrintArray(C);
            }
            else
            {
                Console.WriteLine("Матрицы нельзя перемножить");
            }                


            }
            catch  {
                Console.WriteLine("Вы ввели числа неправильно");
            }
        }
    }
}
