using System;

namespace Zadacha_66
{
    class Zadacha_66
    {
        static int SummNaturalMN(int m, int n){
            int tmp;
            if (m>n) {
                tmp = n;
                n = m;
                m = tmp;
            }
            int summ = 0; 
            for (int i = m; i<=n; i++){
                summ = summ + i;
            }
            return summ;
        }

        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Введите натуральное число m: ");
                int  m = Int32.Parse(Console.ReadLine());
                Console.Write("Введите натуральное число n: ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Сумма натуральных чисел от {m} до {n} -> {SummNaturalMN(m, n)}");  
          
            }
            catch  {
                Console.WriteLine("Вы ввели числа неправильно");
            }
        }
    }
}
