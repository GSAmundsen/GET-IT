using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace IntroClasses
{

    class CharCounter
    {
        public static int range = 250;
        public static int[] counts = new int[range];

        public void AddText(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
        }

        public void ShowCount()
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }
        }

    }
}
