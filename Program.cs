using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            Random a = new Random();
            int max = 0;

            int[] b = new int[N];
            for (int i = 0; i < N; i++)
            {
                b[i] = a.Next(-10, 10);
                Console.WriteLine(b[i]);
            }

            max = b[5];
            for (int i = N-1; i>0; i--)
            {

                if (b[i] > max)
                {
                    max = b[i];
                }
            }
            Console.WriteLine(max);

            Console.ReadKey();

        }
    }
}
