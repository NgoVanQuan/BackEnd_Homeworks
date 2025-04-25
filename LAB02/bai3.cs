using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    class bai3
    {
        
        public static void Dem(int[]a, int n)
        {
            int soduong = 0, soam = 0;
            for (int i = 0; i < n; i++) { 
                if (a[i] > 0)
                {
                    soduong++;
                }
                else if (a[i] < 0) 
                {
                    soam++;
                }
                else
                    {
                        Console.WriteLine("Loi....!");
                    } 

            }
            Console.WriteLine($"So luong so duong: {soduong}");
            Console.WriteLine($"So luong so am: {soam}");
        }
    }
}
