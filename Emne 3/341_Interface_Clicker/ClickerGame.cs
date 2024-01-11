namespace _341_Interface_Clicker
{
    internal class ClickerGame
    {
        private int _points = 0;
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;
        private int _upgradeCost = 10;
        private int _superUpgradeCost = 100;


        public int GetPoints() { return _points; }
        public int GetPointsPerClick() { return _pointsPerClick; }
        public int GetPointsPerClickIncrease() { return _pointsPerClickIncrease; }



        public void IncreasePoints() { _points += _pointsPerClick; }

        public void UpgradePointsPerClick()
        {
            if(_points >= _upgradeCost)
            {
                _pointsPerClick += _pointsPerClickIncrease;
                _points -= _upgradeCost;
            }
        }

        public void SuperUpgradePointsPerClick()
        {
            if(_points >= _superUpgradeCost)
            {
                _pointsPerClickIncrease++;
                _points -= _superUpgradeCost;
            }
                
        }




    }
}
