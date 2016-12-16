using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лекция2_зад3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ;
            int ONE_THOUSAND = 1000; // óñëîâèå, áîëüøå äàííîãî ÷èñëà äàâàòü ñêèäêó.
            int SALE = 15; // ñêèäêà 15 ïðîöåíòîâ
            Console.WriteLine("Ââåäèòå ñóììó âàøåé ïîêóïêè:");
                       if (int.TryParse(Console.ReadLine(), out summ))
                            {
                                if (summ > ONE_THOUSAND)
                                    {
                    double valueDiscount = (summ * SALE) / 100;
                    double result = summ - valueDiscount;
                    Console.WriteLine("Cêèäêà ñîñòàâèëà:" + valueDiscount);
                    Console.WriteLine("Ñóììà ê îïëàòå ñ ó÷¸òîì ñêèäêè:" + result);
                                   }
                                else { Console.WriteLine("Ñóììà âàøåé ïîêóïêè ìåíüøå 1000! Ñêèäêè íåò!"); }
                
                           }
                      else { Console.WriteLine("Íåâåðíîå çíà÷åíèå! Ââåäèòå ÷èñëî."); }
            Console.ReadKey();
        }
    }
}
