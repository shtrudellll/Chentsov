using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] pole = { 1, 2, 4, 8, 15 };

        Console.WriteLine("Maximum: " + HledejMaximum(pole));

        Console.WriteLine("Seřazeno (sestupně): " + SerazeniCisel(pole));

        //Test 4...
        int hledaneCislo = 8;
        int index = BinarySearch(pole, hledaneCislo);
        //yay


        if (index != -1)
        {
            Console.WriteLine($"Číslo {hledaneCislo} ma index {index}");
        }
        else
        {
            Console.WriteLine($"Číslo {hledaneCislo} neni");
        }
    }

    static int HledejMaximum(int[] Pole)
    {
        int max = Pole[0];
        foreach (int cislo in Pole)
        {
            if (cislo > max)
            {
                max = cislo;
            }
        }
        return max;
    }

    static string SerazeniCisel(int[] Pole)
    {
        for (int i = 0; i < Pole.Length - 1; i++)
        {
            int maxI = i;
            for (int j = i + 1; j < Pole.Length; j++)
            {
                if (Pole[j] > Pole[maxI])
                {
                    maxI = j;
                }
            }
            int temp = Pole[i];
            Pole[i] = Pole[maxI];
            Pole[maxI] = temp;
        }

        return string.Join(" ", Pole);
    }
    static int BinarySearch(int[] Pole, int hledaneCislo)
    {
        int left = 0;
        int right = Pole.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (Pole[mid] == hledaneCislo)
            {
                return mid;
            }

            if (Pole[mid] < hledaneCislo)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
