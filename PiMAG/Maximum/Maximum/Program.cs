using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    class Program
    {
         static void Main(string[] args)
        {//���� �������� ��������
            int A, B, C;
           if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
             {
                int Max;
                 // ����  � ������ ���������
                if ((A >= B) && (A >= C))
                 {
                     Max = A;
                 }
                 // �����, ���� B ������ ���������
                else if ((B >= A) && (B >= C))
                 {
                    Max = B;
                 }
                 // ����� - �������� �
                 else
                 {
                     Max = C;
 
                 };
 
                 // ����� ���������� 
                 Console.WriteLine(" ������������ = " + Max);
             }
             // ���������� ���������
             Console.ReadKey();
            
        }
    }
}
