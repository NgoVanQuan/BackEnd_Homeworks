using System;
using LAB02;

namespace LAB2
{
    class Program
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến n
            int n;
            //Nhập giá trị cho biến n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            //Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            //Gọi hàm nhập mảng
            bai1.NhapMang(a, n);
            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình
            Console.WriteLine($"Tổng = {TinhTong(a, n)}");
            int tongChan = bai1.TinhTongChan(a,n);
            Console.WriteLine($"Tong cac phan tu chan trong mang  = {tongChan}");
            bai2.HienThiSoNt(a,n);
            bai3.Dem(a,n);
            int answer = bai4.TimSoLon(a,n);
            Console.WriteLine("So lon thu 2 trong mang la: " + answer);
            int c, d;
            Console.WriteLine("Moi ban nhap c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap d: ");
            d = int.Parse(Console.ReadLine());
            bai5.HoanVi(ref c, ref d);
            Console.WriteLine($"Gia tri cua c: {c}");
            Console.WriteLine($"Gia tri cua d: {d}");
            bai6.SapXepMang(a,n);
            
            
            
            
        }
    }
}
