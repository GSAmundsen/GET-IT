using IntroClasses;

namespace Oppgave321
{
    class Program
    {
        static bool useAlt = true;
        static void Main(string[] args)
        {
            //Første del av oppgaven, telle bokstaver i input.
            if (!useAlt)
            {
                var counter = new CharCounter();
                string text = "something";
                while (!string.IsNullOrWhiteSpace(text))
                {
                    text = Console.ReadLine();
                    counter.AddText(text);
                    counter.ShowCount();

                }
            }
            //Utvidelse av oppgaven, finne matchende navn.
            else
            {
                var text = "something";                
                while (!string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Type in a first name, last name, or press ENTER to view all suspects. Q to exit.");
                    text = Console.ReadLine();
                    if(text == "")
                    {
                        Suspects.PrintAllSuspects();
                    }else if(text is "q" or "Q")
                    {
                        Environment.Exit(0);
                    }

                    Suspects.SelectByName(text);
                    
                }
            }
        }  
    }
}