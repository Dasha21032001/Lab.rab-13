using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            for (int i = 0; i < N/2; i++)
            {
                Console.WriteLine( A[i] + " ");
                Console.WriteLine(A[N-1-i] + " ");
            }
            if (N % 2 == 1)
            {
                Console.WriteLine(A[N / 2]);
            }
            Console.ReadLine();
        }
    }
}
