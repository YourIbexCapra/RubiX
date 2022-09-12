namespace RubiX.Utils
{
    public class Loader : IDisposable
    {
        private const string Sequence = @"▁▂▃▄▅▆▇▆▅▄▃▂";
        private int counter = 0;
        private readonly string msg;
        private readonly int delay;
        private bool active;
        private readonly Thread thread;

        public Loader(string msg = "Loading...", int delay = 80)
        {
            this.msg = msg;
            this.delay = delay;
            thread = new Thread(Spin);
        }

        public void Start()
        {
            active = true;
            if (!thread.IsAlive)
            {
                thread.Start();
            }

        }

        public void Stop()
        {
            active = false;
            Console.Write("\n\n");
            Console.ResetColor();
        }

        private void Spin()
        {
            Console.Write("\n");
            IO.Out(this.msg, ConsoleColor.Yellow);

            while (active)
            {
                Turn();
                Thread.Sleep(delay);
            }
        }

        private void Draw(char c)
        {
            Console.SetCursorPosition(this.msg.Length + 1, Console.CursorTop);
            IO.Out(c.ToString(), ConsoleColor.Red);
            Console.Write("\r");
        }

        private void Turn()
        {
            Draw(Sequence[++counter % Sequence.Length]);
        }

        public void Dispose()
        {
            Stop();
        }
    }
}