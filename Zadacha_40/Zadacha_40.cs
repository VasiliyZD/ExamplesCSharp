/*
задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника, 
является ли он прямоугольным, равнобедренным, равносторонним.
*/
using System;

namespace Zadacha_40
{
    class Zadacha_40
    {
        static bool isTriangle(uint a, uint b, uint c){
            //если есть три числа a,b,c, то они являются сторонами треугольника если a+b>c и b+c>a и a+c>b
            bool res;
            if ((a+b > c) && (b+c > a) && (a+c > b)){   
                res = true;
            }
            else{  
                res = false;
            }
            return res;    

        }
        //Вычисление площади
        static double S(uint a, uint b, uint c){
            double res;
            double p;
            p = (a+b+c)/2.0;
            res = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return res;            
        }
        //Периметр
        static double P(uint a, uint b, uint c){
            double res;
            res = (a+b+c);
            return res;            
        }
        //Равносторонний?
        static bool equilateral(uint a, uint b, uint c){
            bool res;
            res = (a==b) && (b==c) && (a==c);
            return res;            
        }
        
        //Равнобедренный?
        static bool isosceles(uint a, uint b, uint c){
            bool res;
            res = ( (a==b) && !(b==c) && !(a==c)) || 
                  (!(a==b) && !(b==c) && (a==c)) ||
                  (!(a==b) &&  (b==c) && !(a==c));
            return res;            
        }

        //Прямоугольный треугольник
        static bool rightangled(uint a, uint b, uint c){
            bool res = false;
            uint h = a;
            uint k1 = b;
            uint k2 = c; 
            if ((a > b) && (a > c)){
                h = a;
                k1 = b;
                k2 = c;
            } 
            else if ( (b > a) && (b > c)){
                h = b;
                k1 = a;
                k2 = c;
            } 
            else if ( (c > a) && (c > b)){
                h = c;
                k1 = a;
                k2 = b;
            }
            res = (h*h == k1*k1 + k2*k2);
            return res;
        }      
        
        //Углы треугольника cos(β)=(b²+c²−a²)÷(2×b×c); cos(γ)=(a²+c²−b²)÷(2×a×c); cos(α)=(a²+b²−c²)÷(2×a×b).
        //sin(α)=2×S÷(a×b); sin(β)=2×S÷(b×c); sin(γ)=2×S÷(a×c)
        static void angles(uint a, uint b, uint c, out double Alpha, out double Beta, out double Gamma){
            //Alpha = Math.Acos((a*a + b*b - c*c)/2*a*b)*180/Math.PI;
               Alpha = Math.Asin(2*S(a,b,c)/(a*b))*180/Math.PI;     
            //Beta = Math.Acos((b*b + c*c - a*a)/2*c*b)*180/Math.PI;
               Beta = Math.Asin(2*S(a,b,c)/(b*c))*180/Math.PI;     
            //Gamma = Math.Acos((a*a + c*c - b*b)/2*a*c)*180/Math.PI;
               Gamma = Math.Asin(2*S(a,b,c)/(a*c))*180/Math.PI;     
         
        }
  
        static void Main(string[] args)
        {
            uint a = 3;
            uint b = 4;
            uint c = 5;
            try {
                Console.WriteLine("Введите стороны треугольника A, B, С: ");
                Console.Write("Введите сторону A: ");
                a = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите сторону B: ");
                b = UInt32.Parse(Console.ReadLine());
                Console.Write("Введите сторону C: ");
                c = UInt32.Parse(Console.ReadLine());

                if (isTriangle(a, b, c)){
                    double Alpha;
                    double Beta; 
                    double Gamma;
                    double s;
                    double p;
                    s = S(a, b, c);
                    Console.WriteLine($"Площадь S = {s}");
                    p = P(a, b, c);
                    Console.WriteLine($"Периметр P = {p}");

                    angles(a, b, c, out Alpha, out Beta, out Gamma);
                    Console.WriteLine($"Alpha = {Alpha}");
                    Console.WriteLine($"Beta = {Beta}");
                    Console.WriteLine($"Gamma = {Gamma}");
                    if (rightangled(a, b, c)){
                        Console.WriteLine("Треугольник прямоугольный");    
                    };
                    if (isosceles(a, b, c)){
                        Console.WriteLine("Треугольник равнобедренный");    
                    };
                    if (equilateral(a, b, c)){
                        Console.WriteLine("Треугольник равносторонний");    
                    };
                    
                }
                else {
                    Console.WriteLine("Это не треугольник");
                }
            }
            catch{
                Console.WriteLine("Вы ввели не целое положительное число");
            }
        }
    }
}
