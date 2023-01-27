namespace Ekaterina
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("A = ");
            int A = System.Convert.ToInt32(System.Console.ReadLine());
            count(A);
            System.Console.ReadKey(true);
        }

        static void count(int A)
        {
            int res = 0;
            int A1 = A;
            while (A > 0)
            {
                int B = A % 10;
                res+=B;
                A /= 10;
            }
            System.Console.Write("{0} -> {1}", A1, res);
        }
    }
}