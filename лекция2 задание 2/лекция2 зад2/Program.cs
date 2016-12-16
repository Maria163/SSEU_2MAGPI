using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лекция2_зад2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x, f;
            a = 5; b = 12; c = 1992;
            Console.Write("Введите значение X: ");
            double.TryParse(Console.ReadLine(), out x);
            f = (-x / a) * Math.Sqrt(Math.Pow(x, 2) + b * x) + c; // запись формулы с использованием математических функций класса Math
            Console.WriteLine("Функция F(x) равна {0}", f);
            Console.ReadKey();
        }
    }
}
