namespace _341_Interface_Clicker;


class Program
{ 
    static void Main(string[] args)
    {
        ClickerGame game = new ClickerGame();
        CommandSet commands = new CommandSet(game);
        char lastChar = ' ';

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n"
            + " - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       "
            + "koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       "
            + "øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       "
            + "koster 100 poeng\r\n - X = avslutt applikasjonen");
            Console.WriteLine($"Du har {game.GetPoints()} poeng.");
            Console.WriteLine($"Trykk tast for ønsket kommando.");
            Console.WriteLine($"Siste kommando: {lastChar}");
            Console.WriteLine($"Poeng pr klikk: <+{game.GetPointsPerClick()}>");
            Console.WriteLine($"Poeng pr oppgradering: <+{game.GetPointsPerClickIncrease()}>");
            var command = Console.ReadKey().KeyChar;
            lastChar = command;
            commands.RunCommand(command);
        }
    }
}

