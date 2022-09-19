using System;
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
namespace Задача4
{
    class Zadacha4
    {
        static void Main(string[] args)
        {
            int a ; //число a
            int b ; //число b
            int c ; //число c
            int max; //максимальное число
            Console.WriteLine("Введите три числа");
            Console.WriteLine("Введите первое число:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            c = Int32.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.Write(a + " "+ b +" "+ c + " -> ");
            max = (a>b)?a:b;
            max = (max>c)?max:c;
            Console.WriteLine(max);
        }
    }
}
