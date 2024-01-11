namespace _341_Interface_Clicker
{
    internal class Upgrade : ICommand
    {
        private char _hotKey = 'k';
        private ClickerGame _game;
        
        public Upgrade(ClickerGame game)
        {
            _game = game;
        }

        public char GetKey()
        {
            return _hotKey;
        }

        public void Run()
        {
            _game.UpgradePointsPerClick();
        }
    }
}
