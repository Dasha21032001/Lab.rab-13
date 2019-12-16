using System;

namespace Лаб.раб__13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int [] mas = new int[N];
            int c = 1;
            for ( int i = 0; i < N; i++)
            {
               
                mas[i] = (2 * c) - 1;
                c++;
                Console.WriteLine(" " + mas[i]);
            }
            Console.ReadLine();
        }
    }
}
