
namespace RubiX.Utils
{
    class Input : Globals
    {

        public static string input(string pwd = "", string arg = "")
        {
            // Take user input.
            Console.Write(String.Format(_input, pwd, arg));

            string input = "";

            try
            {
                string? _temp = Console.ReadLine();

                if (_temp != null)
                {
                    input = _temp;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, LogLevel.ERROR);
                Logger.Write(ex.Message, LogLevel.ERROR);
            }

            return input;
        }

    }
}
