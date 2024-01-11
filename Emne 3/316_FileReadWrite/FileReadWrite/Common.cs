using System.Text;

namespace FileReadWrite
{
    internal class Common
    {
        static Random random = new Random();

        public static List<string> GenerateList(string fileName)
        {
            return File.ReadAllText(fileName).Split('\t').Distinct().ToList();
        }

        public static string[] GetMatchingWords(string[] wordList, int charCount)
        {
            int randomIndex = random.Next(0, wordList.Length);
            var matchingWords = new List<string>();
            
            string firstWord = wordList[randomIndex];
            string lastLetters = firstWord.Substring(firstWord.Length - charCount);

            for(int i = 0; i < wordList.Length; i++)
            {
                string firstLetters = wordList[i].Substring(0, charCount);
                if(firstLetters == lastLetters)
                {
                    matchingWords.Add(firstWord+" - "+wordList[i]);
                }

            }

            return matchingWords.ToArray();
        }

        
        public static string[] GenerateWords(string fileName)
        {
            List<string> words = new List<string>();
            string lastWord = "";
            
            foreach(var line in File.ReadLines(fileName, Encoding.UTF8))
            {
                string[] parts = line.Split('\t', ' ');
                string word = parts[1];
                if (word != lastWord
                    && word.Length > 4
                    && word.Length < 10
                    && !word.Contains('-'))
                {
                    words.Add(word);
                }
                lastWord = word;
            }

            return words.ToArray();
        }

    }
}
