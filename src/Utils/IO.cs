
namespace RubiX.Utils
{
    class IO
    {
        // Print out.
        public static void Out(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ResetColor();
        }


        // Take user input.
        public static string In(string pwd = "test", string arg = "test")
        {
            // Take user input.
            Out("\n╭─[", ConsoleColor.Cyan);
            Out(pwd, ConsoleColor.Red);
            Out("]", ConsoleColor.Cyan);
            Out("(", ConsoleColor.Cyan);
            Console.Write("💀");
            Out(")", ConsoleColor.Cyan);
            Out("[", ConsoleColor.Cyan);
            Out(arg, ConsoleColor.Red);
            Out("]", ConsoleColor.Cyan);
            Out("\n╰─", ConsoleColor.Cyan);
            Out("λ ", ConsoleColor.Yellow);

            string input = "";

            try
            {
                string? _temp = Console.ReadLine();

                if (_temp != null)
                {
                    input = _temp.ToLower();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, LogLevel.ERROR);
                Logger.Write(ex.Message, LogLevel.ERROR);
            }

            return input;
        }


        // Print logo.
        public static void Logo()
        {
            Console.Clear();
            Out("  ______ _     _ ______  _____ _     _\n |_____/ |     | |_____]   |    \\___/ \n |    \\_ |_____| |_____] __|__ _/   \\_\n", ConsoleColor.Red);
            Out("\n Made with 💗 by YourIbexCapra! ", ConsoleColor.Blue);
            Out("v1.0.0\n", ConsoleColor.Cyan);
        }

    }
}
