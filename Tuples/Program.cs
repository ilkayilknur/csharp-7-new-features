using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            // Before C# 7.0 
            var names = GetNamesOld(7);

            Console.WriteLine("Before");
            Console.WriteLine(string.Format("Name: {0} {1} {2}", names.Item1, names.Item2, names.Item3));

            Console.WriteLine();

            // With C# 7.0

            // Tuple deconstruction 
            var (first, _, last) = GetNames(7); // i only care about first and middle

            Console.WriteLine($"Name: {first} {last}");
             
        }

        static (string f, string m, string l) GetNames(int id) // tuple return type
        {
            string first  = "First";
            string middle = "Middle";
            string last   = "Last";

            var result = (f: first, m: middle, l: last);  // tuple literal

            return result; 
        }

        static Tuple<string, string, string> GetNamesOld(int id)
        {
            string first  = "First";
            string middle = "Middle";
            string last   = "Last";

            return new Tuple<string, string, string>(first, middle, last);
        }
    }
}
