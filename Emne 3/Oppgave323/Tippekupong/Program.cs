using Microsoft.VisualBasic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using Tippekupong;

namespace Tippekupong
{
    internal class Program 
    {

        
        static string today = DateTime.Today.ToString("D", CultureInfo.GetCultureInfo("nb-NO"));

        static void Main(string[] args)
        {
            var match = new Match();
            var bet = "";
            
        

            while (match.isRunning)
            {
                Console.WriteLine($"Dette er status i GET Ligaen {today}: \n\n"); 
                Teams.ShowTeams();
                Console.WriteLine(match.ShowNextMatch()); 
                ShowInstructions();

                bet = CheckInput(Console.ReadLine());
                Console.Clear();
                string result = match.ResolveMatch(bet);
                Console.WriteLine($"Resultatet ble:\n{result}");
                Console.WriteLine($"Du tippet {bet}");
                Console.Write($"\nTrykk en tast for å gå til neste kamp..");
                Console.ReadLine();
                

            }
        }

        static void ShowInstructions()
        {
                Console.Write("\nGyldig tips: \n" +
                " - H, U, B\n" +
                " - halvgardering: HU, HB, UB\n" +
                " - helgardering: HUB\n" +
                "Hva har du tippet for denne kampen? ");
        }

        static string CheckInput(string input)
        {
            if(input is "X" or "H" or "B"){
                return input;
            }else {
                ShowInstructions();
                return "";
            }
        }
    }
}
