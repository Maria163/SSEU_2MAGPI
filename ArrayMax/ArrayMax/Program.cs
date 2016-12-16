using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //ââîä äëèíû ìàññèâà
            int n;
                       do
                           {
               Console.WriteLine("Введите длину массива: ");
                           }
                       while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0)) ;
                       
            Console.Write("Введите целое число: ");
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            //ââîä çíà÷åíèé ìàññèâà
                        //ïîèñê ìàêñèìàëüíîãî çíà÷åíèÿ
                         int i = 0;
            int max = int.MinValue;
            int iMax = 0;
            while (i < n)
            {
                Console.WriteLine("Введите а[" + i + "]: ");
               
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                                      if (a[i] > max)
                                            {
                        max = a[i];
                        iMax = i;
                                            };
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число7!");
                                   };
                           };
                      
             max = a[0];
                       for (i = 1; i < a.Length; i++)
                           {
                                if (a[i] > max)
                                   {
                    max = a[i];
                };
            };
           
            Console.WriteLine("Максимальное значение: " + max);
           
           
            Console.ReadKey();
        }
        }
    }
