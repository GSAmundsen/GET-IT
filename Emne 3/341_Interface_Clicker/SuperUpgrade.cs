namespace _341_Interface_Clicker
{
    internal class SuperUpgrade : ICommand
    {
        private char _hotKey = 's';
        private ClickerGame _game;


        public SuperUpgrade(ClickerGame game)
        {
            _game = game;
        }

        public char GetKey()
        {
            return _hotKey;
        }


        public void Run()
        {
            _game.SuperUpgradePointsPerClick();
        }
    }
}
