
using System;

namespace Задача2
{
    class Zadacha2
    {
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
        static void Main(string[] args)
        {
            int a;
            int b; 
            Console.Write("а = ");
            a = Int32.Parse(Console.ReadLine()) ;//Преобразуем введенное число из строки в число
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine()) ;//Преобразуем введенное число из строки в число
            Console.Clear();//очистка экрана
            Console.Write("а = " + a );// вывод а
            Console.Write(" b = " + b );//вывод b
            Console.Write("->");//вывод ->
            Console.Write(" max = ");//вывод  max =
            Console.WriteLine(a>b?a:b); //вывод большего числа 
        }
    }
}
