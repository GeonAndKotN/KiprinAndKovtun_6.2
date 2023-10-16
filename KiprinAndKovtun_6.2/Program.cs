namespace KiprinAndKovtun_6._2
{
    internal class Program
    {
        //Задача 1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите натуральное число:");
        //    int x = int.Parse(Console.ReadLine());
        //    if (x < 0)
        //    {
        //        Console.WriteLine("ERROR");
        //        return;
        //    }
        //    int result = Summ(x);
        //    Console.WriteLine("Ответ: " + result);
        //}

        //static int Summ(int x)
        //{
        //    if (x <= 0)
        //        return 0;
        //    return x % 10 + Summ(x / 10);
        //}

        //Задача 2 - не решена
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("ERROR");
                return;
            }
            int result = Summ(x);
            Console.WriteLine("Ответ: " + result);
        }


        static int Summ(int x)
        {
            if (x <= 0)
                return 0;
            return x % 10 + Summ(x / 10);
        }

        //Задача 3
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите m");
        //    int m = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите n");
        //    int n = int.Parse(Console.ReadLine());
        //    int result = C(m, n);
        //    Console.WriteLine("Ответ: " + result);
        //}

        //static int C(int m, int n)
        //{
        //    if (m == 0 || m == n)
        //        return 1;
        //    else
        //        return C(m, n - 1) + C(m - 1, n - 1);
        //}
    }
}