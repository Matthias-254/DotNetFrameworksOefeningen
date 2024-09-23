using System.Text.RegularExpressions;

namespace accessors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetalString testje = new GetalString();

            string[] testStrings = {"a-53en nog 2iets5", "123", "abc", "-1a2b3", "0ab", "9x-9y"};

            foreach (var testString in testStrings)
            {
                testje.Getal = testString;
                Console.WriteLine($"Ingevoerde string: {testString} -> Getal: {testje.Getal}");
            }
        }
    }
    public class GetalString
    {
        private string getal;
        public string Getal
        {
            get { return getal; }
            set
            {
                if (int.TryParse(value, out _))
                {
                    getal = value;
                }
                else
                {
                    string resultaat = Regex.Replace(value, @"[^\d-]", "");

                    if (resultaat.StartsWith("-"))
                    {
                        resultaat = "-" + Regex.Replace(resultaat.Substring(1), @"[^0-9]", "");
                    }
                    else
                    {
                        resultaat = Regex.Replace(resultaat, @"[^0-9]", "");
                    }
                    getal = string.IsNullOrEmpty(resultaat) ? "0" : resultaat;
                }
            }
        }
    }
}
