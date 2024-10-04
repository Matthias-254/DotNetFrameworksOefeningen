namespace Event
{
    public delegate void LogEventHandler(string bericht);

    internal class Program
    {
        public static void BerichtNaarOpzichter(string bericht)
        {
            Console.WriteLine("---> Opzichter hoorde: '{0}'", bericht);
        }

        public static void BerichtNaarKlant(string bericht)
        {
            Console.WriteLine("---> Klant hoorde ook: '{0}'", bericht);
        }

        static void Main(string[] args)
        {
            Stapel<string> stapel = new Stapel<string>();

            stapel.InhoudGewijzigd += new LogEventHandler(BerichtNaarOpzichter);
            stapel.InhoudGewijzigd += new LogEventHandler(BerichtNaarKlant);

            stapel.Toevoegen("Item 1");
            stapel.Toevoegen("Item 2");

            stapel.Verwijderen();

            stapel.Leegmaken();
        }

        public class Stapel<T>
        {
            private Stack<T> stack;

            public event LogEventHandler InhoudGewijzigd;

            public Stapel()
            {
                Leegmaken();
            }

            public void Toevoegen(T item)
            {
                stack.Push(item);
                OnInhoudGewijzigd($"Toegevoegd: {item.ToString()}");
            }

            public T Verwijderen()
            {
                T item = stack.Pop();
                OnInhoudGewijzigd($"Verwijderd: {item.ToString()}");
                return item;
            }

            public void Leegmaken()
            {
                stack = new Stack<T>();
                OnInhoudGewijzigd("Leeggemaakt");
            }

            protected virtual void OnInhoudGewijzigd(string bericht)
            {
                if (InhoudGewijzigd != null)
                {
                    InhoudGewijzigd(bericht);
                }
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
    }
}
