namespace VergrootArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mijnArray = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine("Oorspronkelijke array:");
            PrintArray(mijnArray);

            Console.WriteLine("\nVoeg vijfde element toe:");
            mijnArray = VergrootArray(mijnArray, 5);
            PrintArray(mijnArray);

            Console.WriteLine("\nVoeg zesde element toe:");
            mijnArray = VergrootArray(mijnArray, 6);
            PrintArray(mijnArray);

            Console.WriteLine("\nVoeg zevende element toe:");
            mijnArray = VergrootArray(mijnArray, 7);
            PrintArray(mijnArray);

            Console.WriteLine("\nVoeg achtste element toe:");
            mijnArray = VergrootArray(mijnArray, 8);
            PrintArray(mijnArray);
        }

        static int[] VergrootArray(int[] oudeArray, int nieuwElement)
        {
            int[] nieuweArray = new int[oudeArray.Length + 1];

            for (int i = 0; i < oudeArray.Length; i++)
            {
                nieuweArray[i] = oudeArray[i];
            }

            nieuweArray[nieuweArray.Length - 1] = nieuwElement;

            return nieuweArray;
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
