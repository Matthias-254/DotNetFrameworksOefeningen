namespace GeneriekeCollecties
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var intStapel = new Stapel<int>();
            intStapel.Opzetten(10);
            intStapel.Opzetten(20);
            intStapel.Opzetten(30);
            Console.WriteLine("Integer stapel:");
            Console.WriteLine(intStapel.ToString());

            Console.WriteLine("Afhalen van integer stapel: " + intStapel.Afhalen());
            Console.WriteLine(intStapel.ToString());

            var stringStapel = new Stapel<string>();
            stringStapel.Opzetten("Hallo");
            stringStapel.Opzetten("Wereld");
            stringStapel.Opzetten("Generieke klasse");
            Console.WriteLine("\nString stapel:");
            Console.WriteLine(stringStapel.ToString());

            Console.WriteLine("Afhalen van string stapel: " + stringStapel.Afhalen());
            Console.WriteLine(stringStapel.ToString());

            var persoonStapel = new Stapel<Persoon>();
            persoonStapel.Opzetten(new Persoon { Naam = "Jan", Leeftijd = 30 });
            persoonStapel.Opzetten(new Persoon { Naam = "Piet", Leeftijd = 25 });
            persoonStapel.Opzetten(new Persoon { Naam = "Klaas", Leeftijd = 40 });
            Console.WriteLine("\nPersoon stapel:");
            Console.WriteLine(persoonStapel.ToString());

            Console.WriteLine("Afhalen van persoon stapel: " + persoonStapel.Afhalen());
            Console.WriteLine(persoonStapel.ToString());
        }

        public class Stapel<T>
        {
            private Stack<T> stack;

            public Stapel()
            {
                Leegmaken();
            }

            public void Opzetten(T item)
            {
                stack.Push(item);
            }

            public T Afhalen()
            {
                return stack.Pop();
            }

            public void Leegmaken()
            {
                stack = new Stack<T>();
            }

            public override string ToString()
            {
                string s = "";
                foreach (T item in stack)
                {
                    s += item.ToString() + "\n";
                }
                return s;
            }
        }
        public class Persoon
        {
            public string Naam { get; set; }
            public int Leeftijd { get; set; }

            public override string ToString()
            {
                return $"Naam: {Naam}, Leeftijd: {Leeftijd}";
            }
        }
    }
}
