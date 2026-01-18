using System;
using System.Runtime.ExceptionServices;

namespace funnyass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolik je studentu?");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> jmena = new List<string>();
            List<string> veka = new List<string>();
            List<string> przny = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("jmeno zaka {0}", i + 1);
                string jmeno = Console.ReadLine();
                //Console.WriteLine(jmeno);
                jmena.Add(jmeno);
                Console.WriteLine("vek");
                string vek = Console.ReadLine();
                veka.Add(vek);
                Console.WriteLine("prum_znamka");
                string przn = Console.ReadLine();
                przny.Add(przn);
            }
            //Console.WriteLine(jmena[1]);
            int s = 1;
            int n1 = 0;
            float sum = 0;
            int work = 0;

            string cod = "";
            while (work == 0)
            {
                Console.WriteLine("co chcete delat?");
                cod = Console.ReadLine();
                if (cod == "a")
                {
                    for (int i = 0; i < jmena.Count; i++)
                    {


                        while (n1 != n)
                        {
                            Console.WriteLine("zak {0}", n1 + 1);
                            Console.WriteLine(jmena[n1]);
                            Console.WriteLine("jeho vek ");
                            Console.WriteLine(veka[n1]);
                            Console.WriteLine("jeho pr_znamka");
                            Console.WriteLine(przny[n1]);
                            n1++;
                        }
                    }
                    cod = "";
                    n1 = 0;
                }
                else if (cod == "b")
                {
                    for (int i = 0; i < jmena.Count; i++)
                    {

                        if (float.Parse(przny[i]) <= 2)
                        {
                            Console.WriteLine("zak {0}", n1 + 1);
                            Console.WriteLine(jmena[n1]);
                            Console.WriteLine("jeho vek ");
                            Console.WriteLine(veka[n1]);
                            Console.WriteLine("jeho pr_znamka");
                            Console.WriteLine(przny[n1]);

                        }
                        n1++;

                    }
                    cod = null;
                    n1 = 0;
                }
                else if (cod == "c")
                {
                    for (int i = 0; i < veka.Count; i++)
                    {
                        sum = sum + float.Parse(veka[i]);
                    }
                    sum = sum / veka.Count;
                    Console.WriteLine("prumerny vek = {0}", sum);
                    cod = null;
                }
                else if (cod == "d")
                {
                    Console.WriteLine("Adios");
                    work = 1;

                }



                // ODSUD ZACINA NOVY CONTENT



                else if (cod == "e")
                {
                    Console.WriteLine("zadej cislo");
                    int cislo = Convert.ToInt32(Console.ReadLine());

                    int delitel = 0;
                    for (int i = 1; i <= cislo; i++)
                    {
                        if (cislo % i == 0)
                        {
                            delitel++;
                        }
                    }

                    if (delitel == 2)
                        Console.WriteLine("Cislo je prvocislo");
                    else
                        Console.WriteLine("Cislo neni prvocislo");

                    cod = "";
                }
                else if (cod == "f")
                {
                    Console.WriteLine("zadej cislo");
                    int cislo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Rozklad: ");
                    for (int i = 2; i <= cislo; i++)
                    {
                        while (cislo % i == 0)
                        {
                            Console.Write(i);
                            cislo = cislo / i;
                            if (cislo > 1)
                                Console.Write(" * ");
                        }
                    }
                    Console.WriteLine();
                    cod = "";
                }
            }
        }
    }
}