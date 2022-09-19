/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

5
0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.
*/
using System;
using System.Linq;

namespace Zadacha_41M
{
    class Zadacha_41M
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
            Console.Write("Вводите числа через запятую - конец ввода - ENTER : ");
                        int[] a = new int[100]; //Массив из m чисел
                        try {
                            a = Console.ReadLine()
                                            .Split(new[] {','}, StringSplitOptions .RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray(); //считывание m чисел
                            for (int i = 0; i< a.Length; i++ ){
                                Console.Write(a[i]+ " ");
                            }

                            Console.WriteLine(" -> " + g0(a));

                        }
                        catch
                         { 
                            Console.WriteLine("Вы ввели числа неправильно");            
                         }
                        //Console.Clear();
                        

                    
                    
         
        }
    }
}
