//Oppgave 329 A  
//En spiller har et navn og et antall poeng. Når to spiller mot hverandre, vil den ene miste et poeng
//og den andre få et poeng. Koden under simulerer tre spillere med 10 poeng hver - og ti runder hvor
//to tilfeldige av dem spiller mot hverandre. Metoden Play() skal inneholde en måte å velge en tilfeldig
//vinner og taper av de som blir trukket. Vinneren skal få 1 poeng , taperen mister 1 poeng.
//Til slutt vises det hvor mange poeng hver av dem har. Lag klassen Player, slik at koden under fungerer:

namespace PlayersAndPoints
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var players = new[] { new Player("Per", 10), new Player("Pål", 10), new Player("Espen", 10) };
            for (var round = 1; round <= 20; round++)
            {
                var playerIndex1 = random.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];
                player1.Play(player2);
            }

            foreach (var player in players)
            {
                player.ShowNameAndPoints();
            }
        }
    }
}