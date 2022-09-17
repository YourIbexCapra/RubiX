using RubiX.Interface;

namespace RubiX.Utils
{
    class Format : IFormat
    {
        public string Value { get; set; }
        public ConsoleColor Color { get; set; }

        public Format(string value, ConsoleColor color)
        {
            this.Value = value;
            this.Color = color;
        }
    }
}
