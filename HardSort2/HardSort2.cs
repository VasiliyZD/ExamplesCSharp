/*
Задача HARD SORT.

Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

Например, задан массив:
1 4 7 2
5 9 10 3

После сортировки
1 2 3 4
5 7 9 10
*/using System;

namespace HardSort2
{
    class HardSort2
    {
        static int z_from_i_j(int i, int j, int rows, int columns){
            int z = i + j*rows;
            return z;
        }
        static void i_j_from_z(int z, int rows, int columns, out int i, out int j){
            i = z % rows;
            j = (z - i)/rows;
            
        }

        static  void  SampleSort(ref int [,] a){

            int i, j,  min,  temp;
            for(i=0; i < a.GetLength(0)*a.GetLength(1) - 1; i++)
            {
                    
                    min = i; //устанавливаем начальное значение минимального индекса
                    //min1 = i1;
                    int rmin=0;
                    int cmin=0;
                    
                    //находим минимальный индекс элемента
                    for (j = i + 1; j < a.GetLength(0)*a.GetLength(1); j++)
                    {
                            int r1, c1, r2, c2;

                            i_j_from_z(j, a.GetLength(0), a.GetLength(1), out r1, out c1);
                            i_j_from_z(min, a.GetLength(0), a.GetLength(1), out r2, out c2);
                            if (a[r1,c1] < a[r2,c2]){
                                rmin = r1;
                                cmin = c1;
                            }    
                      
                    }            
                            //меняем значения местами
                    int r, c;
                    i_j_from_z(i, a.GetLength(0), a.GetLength(1), out r, out c);
                                    
                    temp = a[r,c];
                    a[r,c] = a[rmin,cmin];
                    a[rmin,cmin] = temp;
                       
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
                for (int i = 0; i<rows; i++){
                    for (int j = 0; j<columns; j++){
                            int z = z_from_i_j( i, j, (int) rows, (int) columns);
                            Console.Write("z:="+z);

                            i_j_from_z(z, (int) rows, (int) columns, out  i, out j);
                            Console.Write("i:="+i+", j:="+j + "\t");
                            
                    }
                    Console.WriteLine();
                    
                }    
                
      
                PrintArray(a);
                //int [] m = Array2D_1D(ref a);
                SampleSort(ref a);
                //a =  Array1D_2D(ref m, (int) columns, (int) rows);
                Console.WriteLine("Отсортированный массив: ");
                PrintArray(a);


            }
            catch{
                Console.WriteLine("Вы ввели числа неправильно");
            }
        }
    }
}

