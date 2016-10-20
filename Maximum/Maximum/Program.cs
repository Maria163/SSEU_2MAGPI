using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных значений 
            int A, B;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            
            // максимальное значение
            int Max;

            // если больше А
            if (A >= B)
            {
                Max = A;
            }
            //если больше В
            else
            {
                Max = B;
            }
          //вывод результата
            Console.WriteLine("Максимальное =" + Max);
            //завершение программы
            Console.ReadKey();


    

        }
    }
}
