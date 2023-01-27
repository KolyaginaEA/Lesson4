namespace Ekaterina
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.Write("A = ");
            int A = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("B = ");
            int B = System.Convert.ToInt32(System.Console.ReadLine());
            pow(A, B);
            System.Console.ReadKey(true);
        }

        static void pow(int A, int B)
        {
            int A1 = A;
            if (B < 0) System.Console.Write("Отрицательная степень");
            else if (B == 0)
            {
                A = 1;
                System.Console.Write("({0}, {1}) -> {2}", A1, B, A);
            }
            else
            {
                for (int i = 1; i < B; i++)
                {
                    A *= A1;
                }
                System.Console.Write("({0}, {1}) -> {2}", A1, B, A);
            }
        }
    }
}