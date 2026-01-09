namespace Rezervační_systém_do_kina
{
    internal class Program
    {
        const int Rady = 8;
        const int Sedadla = 10;
        const int Cena = 180;
        const int Priplatek = 70;
        static int[,] kinosal = new int[Sedadla, Rady];
        static int cenated = Cena;

        static int GetReservationAmount()
        {
            Console.WriteLine("Dobry den, kolik listku se chcete objednat?");
            return Convert.ToInt32(Console.ReadLine()); ;
        }

        static Tuple<int, int> ReadInput()
        {
            Console.WriteLine("vyberte si radu");
            int vybranaRada = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Vyberte si sedadlo");
            int vybraneSedadlo = Convert.ToInt32(Console.ReadLine()) - 1;
            return Tuple.Create(vybranaRada, vybraneSedadlo);
        }

        static bool IsSeatAvailable(int Sedadlo, int Rad)
        {
            if (Sedadlo >= 0 && Sedadlo < 10 && Rad >= 0 && Rad < 8) return kinosal[Sedadlo, Rad] == 0;
            return false;
        }

        static void AddVIPCost(int Rad)
        {
            if (Rad == 6 || Rad == 7)
            {
                cenated += Priplatek;
                Console.WriteLine("Vybrali jste VIP místo. VIP priplatek je 70kc. Jste s tim vpohode?");
            }
        }

        static bool ReserveSeat()
        {
            Tuple<int, int> seat = ReadInput();
            int vybranaRada = seat.Item1;
            int vybraneSedadlo = seat.Item2;
            cenated = Cena;
            AddVIPCost(vybranaRada);
            if (IsSeatAvailable(vybraneSedadlo, vybranaRada))
            {
                Console.WriteLine("Tohle místo je volné, vase cena je: " + cenated + "u ok???????");
                string odpoved = Console.ReadLine();
                if (odpoved.ToLower() == "ano")
                {
                    kinosal[vybraneSedadlo, vybranaRada] = 1;
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Tohle místo už je vybrané");
            }
            return false;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int reservationAmount = GetReservationAmount();
                if (reservationAmount == 0)
                {
                    break;
                }
                while (reservationAmount > 0)
                {
                    if (ReserveSeat()) reservationAmount--;
                }
            }
            for (int i = 0; i < Rady; i++)
            {
                for (int j = 0; j < Sedadla; j++)
                {
                    Console.Write(kinosal[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}