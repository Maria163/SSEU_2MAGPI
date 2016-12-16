using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лекция_4_П4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово,разделенные пробелом:");
            string words = Console.ReadLine();
            
            string[]wordsArr = words.Split(' ');
            Array.Sort(wordsArr);
            words = wordsArr[0];
                        for (int i = 0; i < wordsArr.Length; ++i)
                words = words + ' ' + wordsArr[i];
            
            Console.WriteLine("Сортировка слов по алфавиту:");
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}
