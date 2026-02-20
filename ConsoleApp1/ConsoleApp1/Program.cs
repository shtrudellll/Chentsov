using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        public static class MorseDictionary
        {
            public static readonly Dictionary<string, char> MorseToChar =
                new Dictionary<string, char>
            {
        { ".-", 'A' },    { "-...", 'B' },  { "-.-.", 'C' },
        { "-..", 'D' },   { ".", 'E' },     { "..-.", 'F' },
        { "--.", 'G' },   { "....", 'H' },  { "..", 'I' },
        { ".---", 'J' },  { "-.-", 'K' },   { ".-..", 'L' },
        { "--", 'M' },    { "-.", 'N' },    { "---", 'O' },
        { ".--.", 'P' },  { "--.-", 'Q' },  { ".-.", 'R' },
        { "...", 'S' },   { "-", 'T' },     { "..-", 'U' },
        { "...-", 'V' },  { ".--", 'W' },   { "-..-", 'X' },
        { "-.--", 'Y' },  { "--..", 'Z' },

        { "-----", '0' }, { ".----", '1' }, { "..---", '2' },
        { "...--", '3' }, { "....-", '4' }, { ".....", '5' },
        { "-....", '6' }, { "--...", '7' }, { "---..", '8' },
        { "----.", '9' }
            };
        }

        static void Main(string[] args)
        {
            string full="";
            string encoded = "-../---/-.../.-./-.-- -.././-. .--./.-/-./.. ..-/-.-./../-/./.-../-.-/---"; //Console.ReadLine();
            char current=' ';

            string word = "";
            int a = 0;
            int b = 1;
            int c = 0;
            while (true)
            {

                while (true)
                {

                    current = encoded[a];
                    if (Convert.ToString(current) == "/")
                    {
                        a += 1;
                        break;
                    }
                    if (Convert.ToString(current) == " ")
                    {
                        a += 1;
                        c = 1;
                        
                        break;
                    }
                    word += current;
                    ++a;
                    if (c==1)
                    {
                        full += " ";
                        c = 0;
                    }
                    if (a >= encoded.Length)
                    {
                        b = 0;
                        break;
                    }
                }
                char letter = MorseDictionary.MorseToChar[word];
                full += letter;
                if (b == 0)
                {
                    break;
                }
                word = "";
            }
            Console.WriteLine(full);

        }
    }
}
