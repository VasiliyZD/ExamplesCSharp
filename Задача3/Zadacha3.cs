using System;
using System.Linq;
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
namespace Задача3
{
    class Zadacha3
    {
        static void Main(string[] args)
        {
            int[] a = new int[3]; //Массив из 3 чисел
            Console.WriteLine("Введите три числа");
            
            a = Console.ReadLine()
                              .Split(new[] {' '}, StringSplitOptions .RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray(); //считывание трех чисел
            Console.Clear();
            for (int i = 0; i< a.Length; i++ ){
                Console.Write(a[i]+ " ");
            }

            Console.WriteLine(" -> " + a.Max());
        }
    }
}
