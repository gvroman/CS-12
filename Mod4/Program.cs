namespace Mod4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            foreach(string arg in args)
            {
                Console.WriteLine(arg);

                int num = int.Parse(arg);
                res += num;
            }
            Console.WriteLine(res);
        }
    }
}
