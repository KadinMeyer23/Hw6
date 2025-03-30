namespace LeetCode3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Array_Synthesizer aP1 = new Array_Synthesizer();
            int[] Array_Of_Nums = { 1, 2, 3, 2, 4, 5, 6, 2 };
            int Number = 2;
            int k = 0;
            for (int i = 0; i < Array_Of_Nums.Length; i++)
            {
                if (Array_Of_Nums[i] != Number) { k++; }
            }



            int[] x = aP1.Num_Reducer(Array_Of_Nums, Number,k);

            Console.Write(k+",Nums = [");

            for (int i = 0; i < x.Length; i++) {Console.Write(x[i]+", ");}
            for (int i = 0; i < Array_Of_Nums.Length - x.Length-1; i++) { Console.Write(", "); }
            Console.WriteLine("]");
           
        }
    }
}