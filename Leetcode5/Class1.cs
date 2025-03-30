//Kadin Meyer
//3/30/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode5
{
    public class Even_Odd
    {

        public int[] Make_Even_Odd(int[]Array1) 
        {
            int[]Array2 = new int[Array1.Length];
            int inc = 0;
            int inc2 = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] % 2 == 0) { Array2[inc] = Array1[i]; inc++; }
                else { Array2[Array2.Length - inc2-1] = Array1[i]; inc2++; }
            }


            return Array2;
        }

    }
}
