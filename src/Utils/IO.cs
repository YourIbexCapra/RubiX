using RubiX.Interface;
namespace RubiX.Utils
{
    class IO
    {
        // Print pretty.
        public static void PPrint(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ResetColor();
        }

        // Multi Out in single line.
        public static void Out<T>(params T[] msgs) where T : class, IFormat
        {
            foreach (T msg in msgs)
            {
                PPrint(msg.Value, msg.Color);
            }
        }

        // Take user input.
        public static string In(string pwd = "test", string arg = "test")
        {

            Out<Format>(new Format(
                "\n╭─[", ConsoleColor.Cyan),
                new Format(pwd, ConsoleColor.Red),
                new Format("](💀)[", ConsoleColor.Cyan),
                new Format(arg, ConsoleColor.Red),
                new Format("]\n╰─", ConsoleColor.Cyan),
                new Format("λ ", ConsoleColor.Yellow)
                );

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
            Out<Format>(
                new Format("  ______ _     _ ______  _____ _     _\n |_____/ |     | |_____]   |    \\___/ \n |    \\_ |_____| |_____] __|__ _/   \\_\n", ConsoleColor.Red),
                new Format("\n Made with 💗 by YourIbexCapra! ", ConsoleColor.Blue),
                new Format("v1.0.0\n", ConsoleColor.Cyan));
        }

    }
}
