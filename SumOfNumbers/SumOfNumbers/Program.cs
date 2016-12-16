using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        
                int N;
                int x; // одно число
                if ( int.TryParse(Console.ReadLine (), out N))
                {
                    int Sum = 0; 
                    for (int i = 0; i < N; i ++)
                        if (int.TryParse(Console.ReadLine(), out x))
                        {
                            Sum += x; //добавить к сумме

                        };
                };



            Console.WriteLine(+Sum);
           

            Console.ReadKey();

        }
    }
}
