using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лекция_2_зад_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру в градусах цельсия: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine("Температура по Фаренгейту равна : {0}", f);
            Console.ReadKey();
        }
    }
}
