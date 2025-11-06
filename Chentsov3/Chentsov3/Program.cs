using System.ComponentModel;
using System.Xml.Linq;

namespace Spojak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList spojak = new LinkedList();               //tady se vsechno odehrava
            spojak.AddToEnd(5);
            spojak.AddToEnd(3);
            spojak.AddToEnd(2);
            spojak.AddToEnd(5);
            spojak.AddToEnd(5);
            Console.WriteLine("Spojak:");
            spojak.Print();
            Console.WriteLine("Max:");
            Console.WriteLine(spojak.FindMax());
            Console.WriteLine("seznam bez poosledniho prvku");
            spojak.Minuslast();
            spojak.Print();
            Console.WriteLine("cislo v seznamu je?");
            Console.WriteLine(spojak.Najdicislo(3));
            Console.WriteLine("spojak bez cisla 5:");
            spojak.killcislo(5);
            spojak.Print();
        }
    }
    class Node
    {
        // konstruktor
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    class LinkedList
    {
        public Node Head { get; set; }
        public void AddToEnd(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new Node(value);
            }
        }

        public void Print()
        {
            Node node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

        }

        // TODO: Najít maximum
        public int? FindMax()                                                                //tady se vsechno pise
        // int s otazníkem znamená nullovatelný int - může obsahovat číslo i null 
        {
            if (Head == null)
            {
                Console.WriteLine("Tento seznam je przádný");
                return null; // nullem naznačíme, že maximum nebylo nalezeno
            }
            else
            {
                Node node = Head;
                int x = node.Value;
                while (node != null)
                {
                    if (node.Value > x)
                    {
                        x = node.Value;
                    }
                    node = node.Next;
                }
                return x;
            }

        }
        public int? Minuslast()
        {
            if (Head == null)
            {
                Console.WriteLine("Tento seznam je przádný");
                return null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                return (null);
            }
        }
        public Boolean Najdicislo(int cislo)
        {
            if (Head == null)
            {
                Console.WriteLine("Tento seznam je przádný");
                return (false);
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    if (cislo == current.Value)
                    {
                        return (true);
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            return(false);
        }
        public void killcislo(int cislo)
        {
            if (Head == null)
            {
                Console.WriteLine("Tento seznam je prázdný");
                return;
            }
            while (Head != null && Head.Value == cislo)
            {
                Head = Head.Next;
            }
            Node current = Head;
            while (current != null && current.Next != null)
            {
                if (current.Next.Value == cislo)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }                                                   ///4 a 5 nedelam.    
            }
        }
    }
}
