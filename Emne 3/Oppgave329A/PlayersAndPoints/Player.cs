using System.Security.Cryptography;

namespace PlayersAndPoints
{
    internal class Player
    {
        Random random = new Random();
        string _playerName;
        int _playerPoints;


        public Player(string pName, int pPoints)
        {
            _playerName = pName;
            _playerPoints = pPoints;
        }

        public void Play(Player player)
        {
            //Gnav
            int p1number = 0;
            int p2number = 0;

            while (p1number == p2number)
            {
                p1number = random.Next(1,14);
                p2number = random.Next(1, 14);
            }

            if(p1number > p2number)
            {
                this._playerPoints++;
                player._playerPoints--;
            }else if(p1number < p2number) {
                this._playerPoints++;
                player._playerPoints--;
            }

        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{this._playerName} - {this._playerPoints} poeng");
        }
    }
}
