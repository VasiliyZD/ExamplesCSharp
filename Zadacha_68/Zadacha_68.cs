/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/
using System;

namespace Zadacha_68
{
    class Zadacha_68
    {
            
        static int A(int n, int m)
        {
            if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
            if (n == 0) return m + 1;
            if (m == 0) return A(n - 1, m);
            return A(n - 1, A(n, m - 1));
        }
   
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Введите натуральное число m: ");
                int  m = Int32.Parse(Console.ReadLine());
                Console.Write("Введите натуральное число n: ");
                int n = Int32.Parse(Console.ReadLine());
                if (n < 0 || m < 0) {
                    Console.WriteLine("Вы ввели отрицательное число");
                }
                else{
                    Console.WriteLine($"Фунция Акермана от A({m},{n}) ->{A(m, n)}");
                
                }
            }    
            catch  {
                Console.WriteLine("Вы ввели числа неправильно");                       
            }

        }
    }
}
