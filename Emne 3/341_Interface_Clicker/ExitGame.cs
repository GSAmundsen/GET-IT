namespace _341_Interface_Clicker
{
    internal class ExitGame : ICommand
    {
        private char _hotKey = 'x';
        public void Run()
        {
            Environment.Exit(0);
        }

        public char GetKey()
        {
            return _hotKey;
        }
    }
}
