//Kadin Meyer
//3/30/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1
{
    public class Array_adder
    {

        public int[] Array_Accumulator(int[] Array_of_Nums, int Target) {
            
            for (int i = 0; i < Array_of_Nums.Length; i++)
            {
                for (int j = 0; j < Array_of_Nums.Length; j++)
                {
                    if (Array_of_Nums[i] + Array_of_Nums[j] == Target)
                    {
                        int[] Final2 = [Array_of_Nums[i], Array_of_Nums[j]];
                        return Final2;
                        
                    }
                }

                
            }
            int[] Final = { -1 };

            return Final;


        }
    }
}
