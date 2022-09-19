using System;

namespace Zadacha_62
{
    class Zadacha_62
    {
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
            int n = 4;             
            int c = 0;
            int r = 0;
            int dr = 0;
            int dc = 1;
            int  [, ] a  = new int [n, n]  ;
             
            
            for (int i=0; i < n*n; i++){
                a[r,c]=(i+1);
                if (c+dc>=n || c+dc<0 || r+dr>=n || r+dr<0 || a[r+dr, c+dc]!=0){
                    int tmp;
                    tmp = dr;
                    dr = dc;
                    dc = -tmp;
                }                
                c = c + dc;
                r = r + dr;
            }            
            PrintArray(a);
        }
    }    
}