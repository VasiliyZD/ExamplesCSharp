/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/
using System;

namespace Zadacha_64
{
    class Zadacha_64
    {
        static void PrintNaturalMN(int m, int n){
            int tmp;
            if (m>n) {
                tmp = n;
                n = m;
                m = tmp;
            }
            for (int i = m; i<=n; i++){
                Console.Write(i); 
                if (i<n) {
                    Console.Write(",");
                }
                else{
                    Console.WriteLine();
                }    
            }
        }

        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Введите натуральное число m: ");
                int  m = Int32.Parse(Console.ReadLine());
                Console.Write("Введите натуральное число n: ");
                int n = Int32.Parse(Console.ReadLine());
                PrintNaturalMN(m, n);  
          
            }
            catch  {
                Console.WriteLine("Вы ввели числа неправильно");
            }
        }
    }
}
