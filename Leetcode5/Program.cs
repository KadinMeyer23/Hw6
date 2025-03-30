//Kadin Meyer
//3/30/2025

namespace Leetcode5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Even_Odd ae1 = new Even_Odd();
            int[] Array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int [] x = ae1.Make_Even_Odd(Array1);
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
