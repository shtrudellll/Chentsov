using System.Collections.Generic;
using System.Net.Quic;

namespace BogoSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 6, 3,3,2,1,51326,136,235,124,235134,6856598,123564,2134625,32465};
            numbers = BS(numbers);
            Console.WriteLine("and the list is....");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static List<int> BS(List<int> numbers)
        {
            int a = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[i -1])
                {
                    i = 0;
                    a++;
                    Console.WriteLine(a);
                    numbers = numbers.Shuffle().ToList();
                }
            }
            return numbers;


        }
    }
}