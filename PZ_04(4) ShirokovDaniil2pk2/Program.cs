namespace PZ_04_4__ShirokovDaniil2pk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = -900; i <= 500; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}