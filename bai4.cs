using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    class bai4
    {
         public static int TimSoLon(int[] arr, int length)
        {
            int max = 0, answer = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] < max)
                {
                    answer = arr[i];
                    break;
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                {
                    answer = max;
                    max = arr[i];
                    
                }
                else if (arr[i] > answer && arr[i] < max)
                {
                    answer = arr[i];
                }
            }
            return answer;
        }
    }
}
