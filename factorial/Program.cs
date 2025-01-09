namespace factorial
{
    internal class Program
    {
        static long Ffactorial(int n)
        {
            long res = 1;
            for( int i = 1; i <= n; i++ ) 
            {
                res *= i;
            }
            return res;
        }

        static long Rfactorial(int n) 
        {
            return  n < 1 ? 1 : n*Rfactorial(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Ffactorial(-1));
            Console.WriteLine(Program.Rfactorial(-1));

        }
    }
}
