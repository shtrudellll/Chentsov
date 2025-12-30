   namespace _Fronta_a__ZÁSOBNÍK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seznam = ("{[()()](");
            Stack<string> s = new Stack<string>();

            string[] ot = ["{", "[", "("];
            string[] zav = ["}", "]", ")"];

            for (int i = 0; i < seznam.Length; i++)
            {
                if (s.Count == 0)
                {
                    s.Push(seznam[i].ToString());

                }
                else
                {
                    if (seznam[i].ToString() == ot[0] || seznam[i].ToString() == ot[1] || seznam[i].ToString() == ot[2])
                    {
                        s.Push(seznam[i].ToString());
                    }
                else if (seznam[i].ToString() == zav[0] || seznam[i].ToString() == zav[1] || seznam[i].ToString() == zav[2])
                    {
                        string a = s.Peek();
                        if (seznam[i].ToString() == zav[0] && a == ot[0])
                        {
                            s.Pop();

                        }
                        else if (seznam[i].ToString() == zav[1] && a == ot[1])
                        {
                            s.Pop();

                        }
                        else if (seznam[i].ToString() == zav[2] && a == ot[2])
                        {
                            s.Pop();

                        }
                        else
                        {
                            Console.WriteLine("nuh uh");
                            return;
                        }
                    }
                }
            }
            if (s.Count == 0)
            {
                Console.WriteLine("asi to jde");
            }
            else
            {
                Console.WriteLine("nuh uh");
            }
            


        }
    }
}