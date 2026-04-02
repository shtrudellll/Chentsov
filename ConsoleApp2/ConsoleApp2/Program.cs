using System.Collections.Generic;
using System.Net.Quic;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 6, 3, 5, 2, 1, 8, 9, 3, 4, 9, 12, 29, 1234 };
            numbers = QS(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static List<int> QS(List<int> numbers)
        {
            if (numbers.Count <= 1)
            {
                List<int> ready = numbers;
                return numbers;
            }
            else
            {
                int pivo = numbers[numbers.Count / 2];
                List<int> L = new List<int>();
                List<int> P = new List<int>();
                List<int> S = new List<int>();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == pivo)
                    {
                        S.Add(numbers[i]);
                    }
                    if (numbers[i] > pivo)
                    {
                        P.Add(numbers[i]);
                    }
                    if (numbers[i] < pivo)
                    {
                        L.Add(numbers[i]);
                    }
                }

                List<int> result = new List<int>();

                result.AddRange(QS(L));
                result.AddRange(S);
                result.AddRange(QS(P));

                return result;

            }

        }
    }
}












//kam mame vubec psat bonusy..?

//

//4. ve vstupech kde medián neni hodnota nejbližší průměru jako [1, 2, 3, 4, 1000]