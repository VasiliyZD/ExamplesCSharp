using System;
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/
namespace Zadacha_36
{
    class Zadacha_36
    {
        static int [] rndArr(int n){
            int [] rndA = new int[n] ; 
            Random rand = new Random(); //

            for (int i=0; i<n; i++){
                rndA[i]= rand.Next(-n,n);//Случайные числа от минус n до n
            }
            return rndA;
        }

        static int summOdd(int [] array){
            int summ = 0 ; 

            for (int i=1; i<array.Length; i=i+2){
                summ=summ+array[i];
            }
            return summ;
        }

        static void printArr(int [] a){
            for (int i = 0; i< a.Length; i++ ){
                Console.Write(a[i]+ " ");
            };
            //Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int [] a  =  rndArr(5);            
            printArr(a);
            
            Console.WriteLine(" -> "+ summOdd(a));
        }
    }
}
