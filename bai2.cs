using System;

namespace LAB02
{
    class bai2
    {
        
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static void HienThiSoNt(int[] a, int n)
        {
            Console.WriteLine("Các phần tử là số nguyên tố trong mảng:");
            for (int i = 0; i < n; i++)
            {
                if (KiemTraSoNguyenTo(a[i]))
                {
                    Console.WriteLine($"a[{i}] = {a[i]}");
                }
            }
        }
    }
}
