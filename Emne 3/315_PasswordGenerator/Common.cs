namespace PasswordGenerator
{
    internal class Common
    {
        static string error = "PasswordGenerator  \r\nOptions:\r\n- l = liten bokstav\r\n- L = stor bokstav\r\n- d = siffer\r\n- s = spesialtegn (!\"#¤%&/(){}[]\r\nEksempel: PasswordGenerator 14 lLssdd\r\n    betyr\r\n        Min. 1 liten bokstav\r\n        Min. 1 1 stor bokstav\r\n        Min. 2 spesialtegn\r\n        Min. 2 sifre\r\n        Lengde på passordet skal være 14";
        static string optionsList = "lLsd";
        static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        static string specialChars = "!#¤%&/()=?`*-'¨^@£$|€{[]}";
        public static readonly Random random = new Random();

        public static char WriteRandomLowerCaseLetter()
        {
            char letter = alphabet[random.Next(0, alphabet.Length)];
            return letter;

        }
        public static char WriteRandomUpperCaseLetter()
        {
            char letter = Char.ToUpper(alphabet[random.Next(0, alphabet.Length)]);
            return letter;
        }
        public static int WriteRandomDigit()
        {
            var digit = random.Next(0, 10);//Convert.ToChar(Convert.ToString(random.Next(0, 10)));
            return digit;
        }
        public static char WriteRandomSpecialCharacter()
        {
            char special = specialChars[random.Next(0, alphabet.Length)];
            return special;
        }

        public static bool IsValid(string[] args)
        {
            if (args.Length != 2)
            {
                return false;
            }

            foreach (var c in args[0])
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            foreach (var c in args[1])
            {
                if (!optionsList.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }
        public static void ShowHelpText()
        {
            Console.WriteLine(error);
            Environment.Exit(0);
        }
    }
}
