namespace postfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pre/post?");
            string s = Console.ReadLine();
            Console.WriteLine("what are we solving?");
            string vstup1 = Console.ReadLine(); //- + / * + 12 3 - 7 2 + 4 1 / 18 * 3 2 5 in pre or 8 2 + 5 3 - * 20 4 1 + / + 6 3 1 + * - in post

            if (s == "post")
            {
                Console.WriteLine(Dopost(vstup1));
            }
            else if (s == "pre")
            {
                string vstupreal = PreToPost(vstup1);
                Console.WriteLine((Dopost(vstupreal)));
            }
            //if (s == "post")
            //ConvertPost(vstup1);
        }
        public static float Dopost(string vstup1)
        {
            List<string> list = vstup1.Split(" ").ToList();
            Stack<float> stack = new Stack<float>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "+")
                {
                    if (stack.Count < 2)
                    {
                        throw new Exception("spatny zapis");
                    }
                    float a = stack.Peek();
                    stack.Pop();
                    float b = stack.Peek();
                    stack.Pop();
                    stack.Push(a + b);


                }
                else if (list[i] == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new Exception("spatny zapis");
                    }
                    float a = stack.Peek();
                    stack.Pop();
                    float b = stack.Peek();
                    stack.Pop();
                    stack.Push(a * b);

                }

                else if (list[i] == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new Exception("spatny zapis");
                    }
                    float a = stack.Peek();
                    stack.Pop();
                    float b = stack.Peek();
                    stack.Pop();
                    stack.Push(b - a);

                }
                else if (list[i] == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new Exception("spatny zapis");
                    }
                    float a = stack.Peek();
                    stack.Pop();
                    float b = stack.Peek();
                    stack.Pop();
                    if (a == 0)
                    {
                        throw new Exception("deleni nulou");
                    }
                    stack.Push(b / a);

                }
                else
                {
                    stack.Push(float.Parse(list[i]));
                }
            }
            if (stack.Count == 1)
            {
                float final = stack.Peek();
                return final;
            }
            else
            {
                throw new Exception("az moc cisel zbyo v stacku");
            }
        }
        public static string PreToPost(string vstup1)
        {
            List<string> list = vstup1.Split(" ").ToList();
            Stack<string> stack = new Stack<string>();
            string converted = "";
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if ("+*-/".Contains(list[i]) == true)                                                                                 //cool
                {
                    string a = stack.Pop();
                    string b = stack.Pop();

                    string part = a + " " + b + " " + list[i];
                    stack.Push(part);
                }
                else
                {
                    stack.Push(list[i]);
                }
            }
            return (stack.Pop());
        }
    }
}