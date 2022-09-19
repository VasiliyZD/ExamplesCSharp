using System;

namespace PascalTriangle
{
    class PascalTriangle
    {   
        private int row = 7; //скрытое поле - длина треугольника
        private int cellWidht = 4;// скрытое поле - ширина поля для вывода
        public void set_cellWidht(int cw){
            cellWidht = cw;
        }
 
        public int get_cellWidht(){
            return cellWidht;
        }
 
        //Устанавливает ширину треугольника и оптимальную ширину ячейки
        public void set_row(int r){
            row = r;
                if ((int)(Math.Log10(r)+0.5) > 0)  
                set_cellWidht((int)(Math.Log10(r)+0.5));
                else set_cellWidht(1);
                
            
        }

        public string spaces(){
            string s = "";
            for ( int i=0; i< get_cellWidht(); i++ ){
                s = s + "\t";
            }
            return s;
        }

        //Возвращает заданную ширину треугольника
        public int get_row(){
            return row;
        }
        public void PrintTiangle(){
            for (int y = 0; y < get_row(); y++)
            {
                int c = 1;
                for (int q = 0; q < get_row() - y; q++)
                {
                    System.Console.Write(spaces());
                }
 
                for (int x = 0; x <= y; x++)
                {
                    System.Console.Write(spaces());
                    System.Console.Write(spaces());
                    System.Console.Write("{0:D}", c);
                    c = c * (y - x) / (x + 1);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

      PascalTriangle(int row){
        set_row(row);
      }

 
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Pascal Triangle Program");
            System.Console.Write("Enter the number of rows: ");
            string input = System.Console.ReadLine();
 
            int n = Convert.ToInt32(input);
            PascalTriangle pt = new PascalTriangle(n);
            System.Console.Write(pt.get_cellWidht());
            pt.PrintTiangle();
        }
    }
}
