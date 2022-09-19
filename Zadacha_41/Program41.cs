/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

5
0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.
*/
using System;
using System.Linq;

namespace Zadacha_41
{
    class Program41
    {
       
        static int g0(int [] a){
            int res=0;
            for (int i=0; i<a.Length; i++){
                if (a[i]>0){
                    res++;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Задайте количество чисел M:");
            try {
                    int m = Int32.Parse(Console.ReadLine());
                    if (m > 0) {
                        Console.Write("Введите: "+ m + " чисел через запятую: ");                        
                        int[] a = new int[m]; //Массив из m чисел
                        try {
                            a = Console.ReadLine()
                                            .Split(new[] {','}, StringSplitOptions .RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray(); //считывание m чисел
                        }
                        catch
                         { 
                            Console.Write("Вы ввели числа неправильно");            
                         }
                        //Console.Clear();
                        
                        for (int i = 0; i< a.Length; i++ ){
                            Console.Write(a[i]+ " ");
                        }

                        Console.WriteLine(" -> " + g0(a));


                    }
                    else {
                        Console.Write("Количество чисел должно быть положительным"); 
                    }
            }
            catch {
                Console.Write("Вы ввели не число");
            }
         
        }
    }
}
