using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int S;
            Console.WriteLine("Введите кол-во элементов в массиве( > 2 ):");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите В:");
            int B = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            mas[0] = A;
            mas[1] = B;
            S = mas[0];
            for (int i = 2; i < N; i++)
            {
                mas[i] = mas[i - 1] + S;
                S = mas[i];
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" " + mas[i]);
            }
            Console.ReadLine();
        }
    }
}
