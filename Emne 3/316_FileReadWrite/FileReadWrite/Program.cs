namespace FileReadWrite
{
    internal class Program
    {
        static string[] _wordList;
        static string[] _matchingWords;
        static void Main(string[] args)
        {
            _wordList = Common.GenerateWords("ordliste.txt");
            _matchingWords = Common.GetMatchingWords(_wordList, 3);
            

            foreach (string word in _matchingWords)
            {
                Console.WriteLine(word);    
            }
            
        }
    }
}
