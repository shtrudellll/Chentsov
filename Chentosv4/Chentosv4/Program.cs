using System.ComponentModel.DataAnnotations;

namespace ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 7;
            string vstup = "1-2 1-3 4-5 2-3 2-6 6-7";
            int[,] matice = new int[pocet, pocet];
            string[] dvojice = vstup.Split();
            int i = 1;
            while (i < pocet)
            {
                if (i+1 != pocet)
                {
                    string[] normseznam = dvojice[i].Split("-");
                    int vrchol1 = Convert.ToInt32(normseznam[0]);
                    int vrchol2 = Convert.ToInt32(normseznam[1]);
                    Console.WriteLine(vrchol1 + " " + vrchol2);
                    matice[vrchol1, vrchol2 - 1] = 1;
                    matice[vrchol2 - 1, vrchol1] = 1;
                }
                i++;
            }
           
        }
    }
}