using RubiX.Utils;

namespace RubiX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print logo.
            Console.WriteLine(Globals._logo);

            // Handle CMD args.
            if (args.Length > 0) foreach (string arg in args) Console.WriteLine(arg);

            // Take user input.
            string input = Input.input();

        }
    }
}