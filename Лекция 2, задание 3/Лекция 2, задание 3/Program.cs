using System;
using System.Collections.Generic;
using System.Text;

namespace Лекция_2__задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму покупки:");
            int sum;
            int.TryParse(Console.ReadLine(), out sum);
            double buy;
            if (sum > 1000)
            {
                buy = sum - (sum * 15 / 100);
                Console.WriteLine("Сумма с учетом скидки составляет " + buy);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Cкидка на данную сумму не предоставляется");
            };
            Console.ReadKey();
        }
    }
}
