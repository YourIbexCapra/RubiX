namespace RubiX.Utils
{
    enum LogLevel
    {
        LOG = 0,
        ERROR = 1,
    }

    class Logger
    {
        private static string _log_path = Path.Combine(Path.GetTempPath(), "rubix.log");
        private static string _log_format = "[{0}] <{1}> {2}\n";

        // Log to console.
        public static void Log(string? msg = null, LogLevel level = LogLevel.LOG)
        {
            Console.Write(String.Format(_log_format, level == 0 ? "LOG" : "ERROR", DateTime.Now, msg));
        }

        // Write to temp file.
        public static void Write(string? msg = null, LogLevel level = LogLevel.LOG)
        {
            using (StreamWriter writer = new StreamWriter(_log_path, append: true))
            {
                writer.WriteAsync(String.Format(_log_format, level == 0 ? "LOG" : "ERROR", DateTime.Now, msg));
            }
        }
    }
}