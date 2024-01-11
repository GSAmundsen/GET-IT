namespace Tippekupong
{
    internal class Teams
    {
        static Random random = new Random();
        static List<TeamData> teams = new List<TeamData>()
        {
            new TeamData("Nordlys FC"),
            new TeamData("Sjøulker United"),
            new TeamData("Vulkanvik Vikings"),
            new TeamData("Iskaldt Dynamo"),
            new TeamData("Skogstrollene FC"),
            new TeamData("Gullfiskene United"),
            new TeamData("Måneskinn City"),
            new TeamData("Stormfuglene FC"),
            new TeamData("Elvebryn Rangers"),
            new TeamData("Frostbiten FC"),
            new TeamData("Snøfnugg United"),
            new TeamData("Trolldom Thunder"),
            new TeamData("Himmelblå Hauker"),
            new TeamData("Polarbjørnene FC"),
            new TeamData("Ravnsvart Rovers"),
            new TeamData("Fjelltopp FC")
        };


        public static List<TeamData[]> GenerateMatches()
        {
            List<TeamData> t = teams.ToList();
            List<TeamData[]> matches = new List<TeamData[]>();

            int noOfMatches = teams.Count();

            int counter = 0;
            while (counter < noOfMatches)
            {
                int rand1 = random.Next(0, t.Count());
                int rand2 = random.Next(0, t.Count());
                if (rand1 != rand2)
                {
                    TeamData[] match = { t[rand1], t[rand2] };
                    matches.Add(match);
                    counter++;
                    
                }

            }

            return matches;
        }

        public static void ShowTeams()
        {
            Console.WriteLine("Plass\tPoeng\tSeire\tTap\tLag");
            var sortedTeams = teams.OrderByDescending(team => team.leaguePoints).ToList();
            for(int i = 0; i < teams.Count;i++)
            {
                var t = sortedTeams[i];
                Console.Write($"{i + 1}\t{t.leaguePoints}\t{t.wins}\t{t.losses}\t{t.teamName}\n");
            }
        }

        
    }
}
