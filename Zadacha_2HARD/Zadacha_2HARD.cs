using System;
//задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
//Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
//причем чтобы каждый гарантированно переместился на другое место и выполнить это за m*n / 2 итераций. 
//То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

namespace Zadacha_2HARD
{
    class Zadacha_2HARD
    {
        static int [,] GenArr(uint rows, uint col){
                int[,] a = new int[rows, col];
                Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = (i)*10 + (j);

                    //a[i, j] = random.Next(100);
                    
                }
                
            }
            return a;
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
        static void shuffle(ref int [,] a) {
            
                Random random = new Random();
                int [] a1D = Array2D_1D(ref a);
        for (int i = a1D.Length - 1; i >= 1; i--)
            {
            //do {
            int j = random.Next(i + 1)%(i + 1);
            if (j==i) j = (j+1)%(i + 1);
            // обменять значения data[j] и data[i]
            var temp = a1D[j];
            a1D[j] = a1D[i];
            a1D[i] = temp;
            //} while() 

            }    
        a = Array1D_2D(ref a1D, a.GetLength(1), a.GetLength(0));
       /*
        for (int i = a.GetLength(0)*a.GetLength(1) - 1; i > 0; i--) {
            
            int j = (int) Math.Floor(random.NextDouble() * (i + 1));
            int  tmp;
            a[i] = a[j];


            [, array[j]] = [array[j], array[i]];
            */
        }
               
        static void PrintArray(int [,] a){
            for (int i = 0; i < a.GetLength(0); i++)
            {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            Console.Write(a[i, j] + "\t");
                            //Console.Write("{0,4}", a[i, j]);
                        }
                        Console.WriteLine();
            }
        }

        static T[,] Copy<T>(T[,] array)
        {
        T[,] newArray = new T[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                newArray[i, j] = array[i, j];
        return newArray;
    }

        static void Main(string[] args)
        {
            // for (int k = 0; k< 10000; k++){
            uint rows = 3;
            uint col = 4;
            int[,] a = GenArr(rows, col);
        int[,] b = Copy(a); 
            Array.Copy(a, b, a.GetUpperBound(0) - 1);
            PrintArray(a);
           // PrintArray(b);
            shuffle(ref a);
            Console.WriteLine("Перемешанный массив");
            PrintArray(a);
   
                for (int i = 0; i < a.GetLength(0); i++)
            {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            if(a[i, j]  ==  b[i, j]) {

                                Console.WriteLine( "i="+i+" , "+"j="+ j +"  a["+ i +","+  j+ " ] =" + b[i,j]);
                            }
                        }
                       
            }
            //}


            //Console.WriteLine("Hello World!");
        }
    }
}
