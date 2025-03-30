using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode4
{
    public class arrayCombiner
    {
        public int[] Combined_Array(int[] Array1,int m, int[] Array2, int n) 
        {
            int inc =0 ;
            for (int i = 0;i< Array1.Length; i++) 
            {
                if (i >= m) { Array1[i] = Array2[inc]; inc++; }
            }

            Array.Sort(Array1);
            return Array1;
        }
    }
}
