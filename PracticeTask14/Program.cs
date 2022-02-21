using System;

namespace PracticeTask14
{
    internal class Program
    {
        static int A(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            if (n != 0 && m == 0)
            {
                return A(n - 1, 1);
            }
            if (n > 0 && m > 0)
            {
                return A(n - 1, A(n, m - 1));
            }
            return 0;
        }
        static void image(char Char, int count, bool flag = false) {
            if (Char == 'Z' && flag == false)
            {
                Console.WriteLine(new String(Char, count));
                flag = true;
                image(Char, count, flag);

            }
            else if (Char != 'Z' && flag == false)
            {
                Console.WriteLine(new String(Char, count));
                image((char)((int)(Char) + 1), count - 2, flag);

            }
            else if (Char != 'A' && flag == true)
            {
                Console.WriteLine(new String(Char, count));
                image((char)((int)(Char) - 1), count + 2, flag);

            }
            else if (Char == 'A' && flag == true)
            {
                Console.WriteLine(new String(Char, count));
            }
        }
        static void Main(string[] args)
        {
            
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());
            if (n > 0 && m > 0)
            {
                Console.WriteLine($"Значение функции Аккермана для неотрицательных чисел {n} и {m}: {A(n, m)}");
            }
            image('A', 80);
            
        }
    }
}
