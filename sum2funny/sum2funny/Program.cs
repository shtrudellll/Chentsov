
using System.Net.NetworkInformation;
using System.Security.Cryptography;
namespace sum2funny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int cislo = Convert.ToInt16(Console.ReadLine());
            NajdiDvojici(cisla, cislo);
        }

        static public void NajdiDvojici(int[] cisla, int cislo)
        {
            Dictionary<int, int> umisteni = new Dictionary<int, int>();

            for (int i = 0; i < cisla.Length; i++)
            {

                umisteni.Add(cisla[i], i);
            }
            List<int> ret = new List<int>();

            for (int i = 0; i < cisla.Length; i++)
            {
                if (umisteni.ContainsKey(cislo - cisla[i]) && umisteni[cislo - cisla[i]] != i)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(umisteni[cislo - cisla[i]]);
                    break;
                }
            }
        }
    }
}
