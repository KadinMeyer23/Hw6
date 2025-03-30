//Kadin Meyer
//3/30/25

using System.Data.Common;

namespace LeetCode2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Haystack = "helloB World BaBnana Banana";
            string Needle = "Banana";

            WordFinder aw1 = new WordFinder();
            Console.WriteLine(aw1.Find_Word(Haystack, Needle));

        }
    }
}