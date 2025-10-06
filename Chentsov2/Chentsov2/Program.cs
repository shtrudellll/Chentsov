internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] pole = { 1, 2, 4 };
        Console.WriteLine(HledejMaximum(pole));

        // EXISTUJE  Array.Sort(Pole); !!!!!!!!!111111!!!!!!!!!!!!!!1 
        Console.WriteLine(SerazeniCisel(pole));
    }


    static int HledejMaximum(int[]  Pole)
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
    static void SerazeniCisel(int[] Pole)
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
            //temp je cool
            int temp = Pole[i];
            Pole[i] = Pole[maxI];
            Pole[maxI] = temp;
        }
    }
    static void bins(int[] Pole, )
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
            //temp je cool
            int temp = Pole[i];
            Pole[i] = Pole[maxI];
            Pole[maxI] = temp;
        }
    }
}
