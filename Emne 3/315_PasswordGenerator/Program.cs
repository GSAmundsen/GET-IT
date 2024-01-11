namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Common.IsValid(args))
            {
                Console.WriteLine("Må kjøres i kommandolinje, med riktige argumenter.");
                Common.ShowHelpText();
            }

            var password = "";
            var charAmount = Convert.ToInt32(args[0]);
            var pattern = args[1].PadRight(charAmount, 'l'); //+ new String('l', charAmount - args[1].Length);

            while (pattern.Length > 0)
            {
                int randomIndex = Common.random.Next(0, pattern.Length);
                char currentLetter = pattern[randomIndex];
                if (currentLetter == 'l')
                {
                    password += Common.WriteRandomLowerCaseLetter();
                }
                else if (currentLetter == 'L')
                {
                    password += Common.WriteRandomUpperCaseLetter();
                }
                else if (currentLetter == 's')
                {
                    password += Common.WriteRandomSpecialCharacter();
                }
                else if (currentLetter == 'd')
                {
                    password += Common.WriteRandomDigit();
                }

                pattern = pattern.Remove(randomIndex, 1);

            }

            Console.WriteLine("You random pass is : " + password);
        }
    }
}
