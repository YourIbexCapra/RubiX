namespace RubiX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! v1.0.0");
            if (args.Length > 0) foreach (string arg in args) Console.WriteLine(arg);
        }
    }
}