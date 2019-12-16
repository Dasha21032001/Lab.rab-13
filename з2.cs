using System;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве( > 1 ):");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первый член геометрической прогрессии:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель геометрической прогрессии:");
            int D = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            mas[0] = A;
            for (int i = 1; i < N; i++)
            {
                mas[i] = (int)(A * Math.Pow(D, i));
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" " + mas[i]);
            }
            Console.ReadLine();
        }
    }
}
