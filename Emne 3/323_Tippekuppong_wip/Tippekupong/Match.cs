namespace Tippekupong
{
    class Match
    {
        Random random = new Random();
        int homeTeamAdvantage = 5;

        Weather[] weather = new Weather[] {
            new Weather("strålende sol", 0),
            new Weather("litt overskyet", 1),
            new Weather("litt regn", 2),
            new Weather("øs pøs regnvær", 4),
            new Weather("bærgensk høst", 15),
        };
        public bool isRunning { get; private set;} = true;
        string _bet;
        static List<TeamData[]> Matches = Teams.GenerateMatches();
        int matchCounter = 0;



        public void StopMatch()
        {
            isRunning = false;
        }

        public string ShowNextMatch()
        {
            string nextMatch = $"Neste kamp:\n\n{Matches[matchCounter][0].teamName} og {Matches[matchCounter][1].teamName}";
            return nextMatch;  
        }

        public string ResolveMatch(string bet)
        {
            
            var hometeam = Matches[matchCounter][0];
            var awayteam = Matches[matchCounter][1];
            var homeTeamGoals = 0;
            var awayTeamGoals = 0;

            var todaysWeather = weather[random.Next(weather.Length)];

            string result = "";
            var homeTeamTotalChanceToScore = 
                hometeam.skillLevel_General 
                + (hometeam.skillLevel_DeadBall / 10) 
                + homeTeamAdvantage
                - (hometeam.skillModifier_Rain + todaysWeather.weatherPenalty);

            var awayTeamTotalChanceToScore =
                awayteam.skillLevel_General
                + (awayteam.skillLevel_DeadBall / 10)
                - (awayteam.skillModifier_Rain + todaysWeather.weatherPenalty);

            var chancesAtGoal = random.Next(3, 10);
            for (int i = 0; i < chancesAtGoal; i++)
            {
                var chanceToScore = random.Next(0, 100);
                if (homeTeamTotalChanceToScore > chanceToScore) { 
                    homeTeamGoals++;
                }else
                {
                    chanceToScore = random.Next(0, 100);
                    if (awayTeamTotalChanceToScore > chanceToScore)
                    {
                        awayTeamGoals++;
                    }
                }
            }

            if (homeTeamGoals > awayTeamGoals) {
                Matches[matchCounter][0].MatchResult(true);
                Matches[matchCounter][1].MatchResult(false);
                result = $"Idag var det {todaysWeather.weatherType} på GET Stadion, og {hometeam.teamName} slo {awayteam.teamName}, {homeTeamGoals}-{awayTeamGoals}";
            }else if(awayTeamGoals > homeTeamGoals){
                Matches[matchCounter][0].MatchResult(false);
                Matches[matchCounter][1].MatchResult(true);
                result = $"Idag var det {todaysWeather.weatherType} på GET Stadion, og {hometeam.teamName} tapte mot {awayteam.teamName}, {homeTeamGoals}-{awayTeamGoals}";
            }
            else
            {
                Matches[matchCounter][0].MatchResult();
                Matches[matchCounter][1].MatchResult();
                result = $"Idag var det {todaysWeather.weatherType} på GET Stadion, og det ble uavgjort mellom {hometeam.teamName} og {awayteam.teamName}, {homeTeamGoals}-{awayTeamGoals}";
            }

            if (matchCounter < Matches.Count)
            {
                matchCounter++;
            }

            return result;
        }

        }
}
