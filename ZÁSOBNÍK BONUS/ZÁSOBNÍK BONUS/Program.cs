using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> rozklad = new List<int>();
        Rozklad(n, 1, rozklad);
    }

    static void Rozklad(int zbytek, int minimum, List<int> aktualni)
    {

        if (zbytek == 0)
        {
            Console.WriteLine(string.Join("+", aktualni));
            return;
        }

        for (int i = minimum; i <= zbytek; i++)
        {
            aktualni.Add(i);
            Rozklad(zbytek - i, i, aktualni);
            aktualni.RemoveAt(aktualni.Count - 1); 
        }
    }
}