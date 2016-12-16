using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лекция_3_зад1
{
    class Program
    {
        static void Main(string[] args)
        {
      int n; //количество чисел
      int i = 1;
      int f = 1;
            Console.WriteLine("Введите колличество чисел для вычисления факториала:");
       if (int.TryParse(Console.ReadLine(), out n))
      while (i < n + 1)
                              {
                              //факториал числа
                f = f * i;
           Console.WriteLine("{" + f + "}");
                i++;
                                };
                           //вывод результата
            Console.WriteLine("Факториал: " + f);
                           //завершение рограммы
            Console.ReadKey();
        }
    }
}
