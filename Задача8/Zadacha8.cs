using System;

namespace Задача8
{
    class Zadacha8
    {
 /*       
 Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 5 -> 2, 4
 8 -> 2, 4, 6, 8
*/
        static void Main(string[] args)
        {
            int N;
            Console.Write("введите число N: ");
            N = Int32.Parse(Console.ReadLine()) ;//Преобразуем введенное число из строки в число
            Console.Clear();
            Console.Write(N + " -> "); //Проверка на четность и вывод да или нет
            
            for (int i=2; i<=N; i++){
                if (i%2==0) {
                    Console.Write(i); //Проверка на четность и вывод да или нет
                    if (i < N-N%2) {
                        Console.Write(", ");
                    }else {
                        Console.WriteLine();
                    }
                }    
            }    
        }
    }
 }
