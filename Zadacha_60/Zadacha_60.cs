/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
using System;

namespace Zadacha_60
{
    class Zadacha_60
    {
        static int [, ,] rnd3DArray(int [] dimensions){
            int [, ,] A3D = new int  [dimensions[0],dimensions[1] ,dimensions[2]];
            int rangeMax = dimensions[0] * dimensions[1] * dimensions[2];
            bool [] rndNumbers = new bool [rangeMax];

            Random random = new Random();
            for (int i = 0; i < dimensions[0]; i++) { 
                for (int j = 0; j < dimensions[1]; j++) {
                    for (int k = 0; k < dimensions[2]; k++) {
                        int rndNum;
                        do {
                            rndNum = random.Next(rangeMax);
                        } 
                        while (rndNumbers[rndNum%rangeMax]!=false);
                        rndNumbers[rndNum%rangeMax] = true;
                        A3D[i, j, k] =   rndNum%rangeMax;//Числа в диапазоне от 0 до rangeMax от 0 до 100

                    }
                }        
                     
            }
            return A3D;
        }

       static void Print3D(ref int [ , , ] a){
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++){
                    for (int k = 0; k < a.GetLength(2); k++){
                        {
                            Console.Write($"{a[i,j,k]}({i}, {j}, {k})    ");
                        }
                        
                    }
                    Console.WriteLine();
                }        
            }
        }

        static void Main(string[] args)
        {   
            int [] dimensions = {2,2,2};
            int [, ,] A3D = rnd3DArray(dimensions);
            Print3D (ref A3D);          

        }
    }
}
