using System;
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

namespace Zadacha_43
{

    class Zadacha_43
    {

        static void ABC_from_kb(double k, double b, out double A, out double B, out double C){
            double x1 = 0.0;
            double x2 = 1.0;
            double y1 =  k*x1 + b;
            double y2 =  k*x2 + b;
            A=y1-y2;
            B=x2-x1;
            C=x1*y2-x2*y1;
        }


        static bool parall(double a1, double a2, double b1, double b2)
        {
            bool res=(a1 / a2) == (b1 / b2);
            if (res)
            {
                Console.WriteLine("Линии параллельны!");
            }
            return res;
        }
        static void intersect(double a1, double a2, double b1, double b2, double c1, double c2, out double x, out double y)
        {
            double det = a1 * b2 - a2 * b1;
            x = (b1 * c2 - b2 * c1) / det;
            y = (a2 * c1 - a1 * c2) / det;

        }
  // уравнение прямой Ax + By + C = 0
  // или y = k*x + b =  -A/B*x - C/B )
  // k =  -A/B
  // b =  -C/B
   
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты прямой b1, k1, b2, k2");

            try {
                Console.Write("b1=");
                int b1 = Int32.Parse(Console.ReadLine());
                Console.Write("k1=");
                int k1 = Int32.Parse(Console.ReadLine());
                Console.Write("b2=");
                int b2 = Int32.Parse(Console.ReadLine());
                Console.Write("k2=");
                int k2 = Int32.Parse(Console.ReadLine());
                double A1,B1,C1;
                ABC_from_kb(k1, b1, out A1, out B1, out C1);
                double A2,B2,C2;
                ABC_from_kb(k2, b2, out A2, out B2, out C2);
                if (!parall(A1, A2, B1, B2)){
                    double x, y;
                    intersect(A1, A2, B1, B2, C1, C2, out x, out y);
                    Console.WriteLine("->(" + x +";" + y + ")");    
                }

            }
            catch {
                Console.WriteLine("Вы ввели не число");     
            }            
           
        }
    }
}
