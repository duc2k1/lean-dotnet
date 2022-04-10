namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 3, 2, 5, 1, 4, 6, 7, 8, 9, 10 };
            a = a.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ", a));
            double[,] b = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        }
        static void HelloWorld()
        {
            System.Console.WriteLine("hello world");
        }
    }
}