namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }

        public class Stapel<T>
        {
            private Stack<T> stack;

            public Stapel()
            {
                Leegmaken();
            }

            public void Toevoegen(T item)
            {
                stack.Push(item);
            }

            public T Verwijderen()
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
    }
}
