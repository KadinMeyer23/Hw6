namespace Leetcode4
{
    public class Program
    {
        static void Main(string[] args)
        {
            arrayCombiner ac1 = new arrayCombiner();
            int m = 4;
            int n = 3;
            int[] Array1 = { 3,15,66,27,0,0,0 };
            
            int[] Array2 = {61,92,33};

            int[] x = ac1.Combined_Array(Array1, m, Array2, n);
            foreach(int i in x) {Console.WriteLine(i);}
            
        }
    }
}
