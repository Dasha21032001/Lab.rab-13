using System;

namespace задание_5
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
            if (N % 2 != 0)
            {
                for (int i = 1; i < N; i += 2)

                    Console.Write(A[i] + " ");

                for (int i = N - 1; i >= 0; i -= 2)

                    Console.Write(A[i] + " ");
            }
            else
            {
                for (int i = 1; i < N; i += 2)

                    Console.Write(A[i] + " ");

                for (int i = N - 2; i >= 0; i -= 2)

                    Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
    }
}