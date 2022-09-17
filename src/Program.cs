using RubiX.Utils;

namespace RubiX
{
    class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            // Print logo.
            IO.Logo();

            // Handle CMD args.
            if (args.Length > 0) foreach (string arg in args) Console.WriteLine(arg);

            while (true)
            {
                // Take user input.
                string input = IO.In();

                switch (input)
                {
                    case "exit":
                        break;

                    case "ls":
                        Console.WriteLine("hello");
                        continue;

                    default:
                        IO.Out<Format>(
                            new Format("\nInvalid command: ", ConsoleColor.Yellow),
                            new Format(input + "\n", ConsoleColor.Red));

                        continue;
                }

                break;
            }

            if (tasks.Count > 0)
                using (Loader loader = new Loader("Shutting down!"))
                {
                    loader.Start();
                    // Close all workers.
                    Thread.Sleep(10000);
                }

            // Done. Exit.
            IO.Out<Format>(new Format("\nDone!\n\n", ConsoleColor.Green));
        }
    }
}