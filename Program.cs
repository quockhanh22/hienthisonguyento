using System;
using System.Text;

namespace hienthisonguyento
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
           Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("CT HIỂN THỊ CÁC SỐ NGUYÊN TỐ NHỎ HƠN N");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Nhập n :");
            int n = int.Parse(Console.ReadLine());
            hienthi();
        }
        static void hienthi()
        {
            int dem = 0;
            Console.Write($"Các số nguyên tố năm trong khoảng {n} là:");
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }

                if (dem == 2)
                {
                    Console.Write($"{i},");
                }
                dem = 0;
            }
        }
    }
}