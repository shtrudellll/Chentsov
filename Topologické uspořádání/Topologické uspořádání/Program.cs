using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_Abecedni_poradi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte vztahy (např. c<b a<c):");
            string[] vztahy = Console.ReadLine().Split();

            // 1. Zjistíme všechny znaky
            List<char> znakyAbecedy = new List<char>();
            foreach (string vztah in vztahy)
            {
                if (!znakyAbecedy.Contains(vztah[0]))
                    znakyAbecedy.Add(vztah[0]);
                if (!znakyAbecedy.Contains(vztah[2]))
                    znakyAbecedy.Add(vztah[2]);
            }

            int pocetVrcholu = znakyAbecedy.Count;

            // 2. Vytvoříme graf (matice sousednosti)
            int[,] graf = new int[pocetVrcholu, pocetVrcholu];
            foreach (string vztah in vztahy)
            {
                int indexZ = znakyAbecedy.IndexOf(vztah[0]);
                int indexDo = znakyAbecedy.IndexOf(vztah[2]);
                graf[indexZ, indexDo] = 1;
            }

            // 3. Spočítáme vstupní stupně (in-degree)
            int[] stupneVrcholu = new int[pocetVrcholu];
            for (int i = 0; i < pocetVrcholu; i++) // pro každý sloupec
            {
                int suma = 0;
                for (int j = 0; j < pocetVrcholu; j++)
                    suma += graf[j, i];
                stupneVrcholu[i] = suma;
            }

            // 4. Najdeme všechny zdroje (in-degree = 0) a vložíme do "fronty" (seznam pro abecední výběr)
            List<int> fronta = new List<int>();
            for (int i = 0; i < pocetVrcholu; i++)
                if (stupneVrcholu[i] == 0)
                    fronta.Add(i);

            List<char> topologickeUsporadani = new List<char>();

            while (fronta.Count > 0)
            {
                // Vyber abecedně nejmenší znak
                fronta.Sort((a, b) => znakyAbecedy[a].CompareTo(znakyAbecedy[b]));
                int vrchol = fronta[0];
                fronta.RemoveAt(0);

                topologickeUsporadani.Add(znakyAbecedy[vrchol]);

                // Snížíme in-degree sousedů
                for (int i = 0; i < pocetVrcholu; i++)
                {
                    if (graf[vrchol, i] == 1)
                    {
                        stupneVrcholu[i]--;
                        if (stupneVrcholu[i] == 0)
                            fronta.Add(i);
                    }
                }
            }

            // 5. Kontrola cyklu
            if (topologickeUsporadani.Count != pocetVrcholu)
            {
                Console.WriteLine("Graf obsahuje cyklus, topologické uspořádání nelze vytvořit.");
            }
            else
            {
                Console.WriteLine("Topologické uspořádání: " + string.Join(" < ", topologickeUsporadani));
            }
        }
    }
}