using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Tippekupong
{
    internal class PlayerData
    {
        public string playerName; 
        public int playerCash;
        public int correctBets = 0;
        public int wrongBets = 0;

        public PlayerData(string playerName, int playerCash, int correctBets, int wrongBets)
        {
            this.playerName = playerName;
            this.playerCash = playerCash;
            this.correctBets = correctBets;
            this.wrongBets = wrongBets;
        }

        public void ChangeCash(int betAmount, float odds)
        {
            playerCash += (int)(betAmount*odds);
        }

        public bool isBankrupt()
        {
            return (playerCash <= 0);
        }

        public void updateScores(int result)
        {
            if (result == 0) { wrongBets++; }
            else { correctBets++; }
        }
    }
}
