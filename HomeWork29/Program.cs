namespace Ekaterina
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            arr(array);
            System.Console.ReadKey(true);
        }
        static void arr(int[] array)
        {
            System.Random myRandom = new System.Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 100);
                System.Console.Write("{0}, ", array[i]);
            }
        }
    }
}