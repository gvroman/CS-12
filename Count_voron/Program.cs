namespace Vorony
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите число ворон на ветке от 0 до 9: ");
            //int n = int.Parse(Console.ReadLine());
            //static string cnt(int n) => n switch
            //{
            //    1 => "На ветке одна ворона"
                //2, 3, 4 => $"На дереве {n} вороны",
                //0, 5, 6, 7, 8, 9 => $"На дереве {n} ворон"
        //    };
        //}

            //Console.Write("Введите число ворон на ветке от 0 до 9: ");
            //int n = int.Parse(Console.ReadLine());
            //string v;
            //switch (n)
            //{
            //    case 1: v = "ворона"; break;
            //    case 2:
            //    case 3:
            //    case 4: v = "вороны"; break;
            //    default: v = "ворон"; break;
            //}  
            
            //Console.WriteLine($"На дереве {n} {v}");
         
            //Console.Write("Введите число ворон на ветке от 0 до 9: ");
            //int n = int.Parse(Console.ReadLine());
            //string v;
            //int n2 = n % 100;            if (n >= 11 && n2 <= 14)
            //    v = "вороны";
            //else
            //    switch (n%10)
            //    {
            //        case 1: v = "ворона"; break;
            //        case 2:
            //        case 3:
            //        case 4: v = "вороны"; break;
            //        default: v = "ворон"; break;
            //    };  
            
            //Console.WriteLine($"На дереве {n} {v}");

            //Console.Write("Введите число ворон на ветке от 0 до 9: ");
            //int n = int.Parse(Console.ReadLine());
            //string v;
            //int n2 = n % 100;            
            //if (n >= 11 && n2 <= 14)
            //    v = "ворон";
            //else
            //    v = (n%10) switch
            //    {
            //        1 => "ворона",
            //        2 or 3 or 4 => "вороны",
            //        _ => "ворон"
            //    };  
            
            //Console.WriteLine($"На дереве {n} {v}");


            Console.Write("Введите число ворон на ветке от 0 до 9: ");
            int n = int.Parse(Console.ReadLine());
            string v;
            int n2 = n % 100;            
            v = (n >= 11 && n2 <= 14) ? "ворон" :
                (n%10) switch
                {
                    1 => "ворона",
                    2 or 3 or 4 => "вороны",
                    _ => "ворон"
                };  
            
            Console.WriteLine($"На дереве {n} {v}");
            
        }
    }
}
