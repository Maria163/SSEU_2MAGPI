using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лекция_4_зад_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Нажмите клавишу");
            char.TryParse(Console.ReadLine(), out a);
            int b;
            b = Convert.ToInt32(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
