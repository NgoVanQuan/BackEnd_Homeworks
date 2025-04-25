using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    class bai6
    {
        public static int SapXepMang(int[] arr, int n)
        {
         
            for (int i = 0; i < n; i++) { 
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                       
                    }
                   
                }
               
            }
            Console.Write("Mang sau khi duoc sx la: ");
            for (int i = 0; i < n; i++) {
                
                Console.Write($"[{arr[i]}]" + "," + " ");
            }
            
            return 0;
            
        }

        
    }
}
