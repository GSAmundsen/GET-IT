namespace _341_Interface_Clicker
{
    internal class Click : ICommand
    {
        private char _hotKey = ' ';
        private ClickerGame _game;
        
        public Click(ClickerGame game)
        {
            _game = game;
        }

        public char GetKey()
        {
            return _hotKey;
        }

        public void Run()
        {
            _game.IncreasePoints();
        }
    
    }

}
