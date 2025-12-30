using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej číslo: ");
        long n = long.Parse(Console.ReadLine());

        Console.Write("Prvočíselný rozklad: ");

        for (long i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.Write(i + " ");
                n /= i;
            }
        }

        if (n > 1)
            Console.Write(n); // zbytek je prvočíslo

        Console.WriteLine();
    }
}
