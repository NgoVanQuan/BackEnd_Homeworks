using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
     class bai5
    {
        public static void HoanVi(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
