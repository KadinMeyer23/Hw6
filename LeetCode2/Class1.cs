using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2
{
    public class WordFinder
    {

        public int Find_Word(string Haystack, string Needle) 
        {
            int j = 0;
            int Marker = -1;
            int Marker2 = -1;


            for (int i = 0; i < Haystack.Length; i++)
            {
                if (Needle[j] == Haystack[i])
                {
                    if (j == 0)
                    {
                        Marker = i;
                        Marker2 = 0;
                    }

                    j++;

                    if (j == Needle.Length)
                    {
                        break;
                    }
                }
                else
                {

                    if (Marker2 != -1)
                    {
                        j = 0;

                        Marker = -1;
                        Marker2 = -1;
                    }
                }
            }

            if (Marker != -1)
            {
                return(Marker);
            }
            else
            {
                return(-1);
            }
        }
    }
}

    
