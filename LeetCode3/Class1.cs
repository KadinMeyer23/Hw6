using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode3
{
    public class Array_Synthesizer
    {

        public int[] Num_Reducer(int[] Array_Of_Nums, int Number, int k) 
        {
            
            int inc = 0;
           

            int[] New_Array = new int[k];
            for (int i = 0; i < Array_Of_Nums.Length; i++) 
            {
                if (Array_Of_Nums[i] != Number) { New_Array[inc] = Array_Of_Nums[i]; inc++; }
                
            }




            return (New_Array);
        }


    }
}
