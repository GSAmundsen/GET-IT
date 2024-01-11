namespace _341_Interface_Clicker
{
    internal class CommandSet
    {
        private ICommand[] commands;
        private ClickerGame _game;

        public CommandSet(ClickerGame clg) {
            _game = clg;
            commands =
            [
                new Click(clg),
                new Upgrade(clg),
                new SuperUpgrade(clg),
                new ExitGame(),                
            ];  
        
        }

        public void RunCommand(char key)
        {
            Console.WriteLine(key);
            foreach (var command in commands)
            {
                if (command.GetKey() == key)
                {
                    command.Run();
                }
            }

        }
    }
}
