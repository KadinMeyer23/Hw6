//Kadin Meyer
//3/30/2025
namespace LeetCode1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Array_adder ad1 = new Array_adder();
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int Target = 7;
            int[] x = ad1.Array_Accumulator(Array, Target);

            if (x.Length == 2)
            {
                Console.WriteLine("["+ x[0] + "," + x[1] + "]");
            }
            else
            {
                Console.WriteLine("[" + x[0] + "]");
            }
        }
    }
}
