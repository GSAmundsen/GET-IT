namespace Tippekupong
{
    internal class TeamData
    {
        static Random random = new Random();
        public string teamName { get; private set;}
        public float skillLevel_General { get; private set; }
        public float skillLevel_DeadBall { get; private set; }
        public int wins { get; private set; }
        public int losses { get; private set; }
        public int draw {  get; private set; }
        public int leaguePoints { get; private set; }
        public int skillModifier_Rain { get; private set; }
        


        public TeamData(string name, float skillLvlGeneral = 0f, float skillLvlPenaltyKicks = 0f, int skillModRain = 0, int win = 0, int loss = 0, int lPoints = 0, int draws = 0){
            teamName = name;
            if(skillLvlGeneral == 0) skillLevel_General = random.Next(35,55);
            if(skillLvlPenaltyKicks == 0) skillLevel_DeadBall = random.Next(5, 20);
            if(skillModRain == 0) skillModifier_Rain = random.Next(0,15);
            wins = win;
            losses = loss;
            leaguePoints = lPoints;
        }

        public void MatchResult(bool? teamWon = null)
        {
            if(teamWon == true)
            {
                wins++;
                leaguePoints += 3;
            }
            else if (teamWon == false) 
            {
                losses++;
            }
            else
            {
                //draw
                draw++;
                leaguePoints += 1;
            }

        }
    }
}
