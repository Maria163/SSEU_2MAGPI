using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лекция_4_зад_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу или предложение для проверки: ");
            string S = Console.ReadLine();
           S = S.Trim(); //удаляем пробелы в конце и начале строки (если они есть)
            string[] a = S.Split(' ', '.', ',', '!', '?', ';', ':', '-'); //заносим в массив a все слова, разделённые символами . , ! ? ; : -) или пробелом
            int max = 0;
            int nomer = 0;
                         for (int i = 0; i < a.Length; i++)
                                  {
                                     if (a[i].Length > max)
                                            {
                    max = a[i].Length;
                    nomer = i;
                                              }
                                   }
            Console.WriteLine("Самое длинное слово: " + a[nomer]);
            Console.WriteLine("В самом длинном слове: " + max + " символов(а)");
            Console.ReadKey();
        }
    }
}
