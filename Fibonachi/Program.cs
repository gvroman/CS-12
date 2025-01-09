namespace Fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 0, b = 1, c;
            //            while (a < 1000)
            //{
            //    Console.WriteLine(a);
            //    if (a == 0)
            //        Console.WriteLine(b);
            //    c = a + b;
            //    if (a >= 2)
            //        b = a;
            //    a = c;
            //}

            int k1 = 0, k2 = 1, k3;
            Console.WriteLine($"{k1}\n{k2}");
            while( (k3 = k1 + k2) < 1000)
            {
                Console.WriteLine(k3);
                k1 = k2;
                k2 = k3;
            }


        }
    }
}
