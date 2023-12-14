//Implementer en brusautomat. Ulike drikker har ulik pris. Automaten har en lagerbeholdning.
//Man kan putte på mynter (1kr, 5kr, 10kr, 20kr). Man trykker på en knapp for en bestemt drikk -
//hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
//Det finnes en knapp for å få gjeldende saldo tilbake.

namespace SodaMachine
{
    internal class Program
    {
        static Machine machine = new Machine();
        static Wallet wallet = new Wallet(6, 3, 3, 2);
        static int[] coins = wallet.GetAmount();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Dette er myntene dine:\n" +
                $"1 - 1kr : {coins[0]}\n" +
                $"2 - 5kr : {coins[1]}\n" +
                $"3 - 10kr: {coins[2]}\n" +
                $"4 - 20kr: {coins[3]}\n\n");

                Console.Write($"Maskinen har dette:" +
                        $"{machine.ReturnContents()}\n" +
                        $"Du har lagt på {} på maskinen\n" +

                        "\nHvor mye ønsker du å legge på maskinen? Eller trykk ENTER for å avbryte");
                var inp = Console.ReadLine();
                
                if (inp == "1")
                {

                }

                if (inp is "")
                {
                    Console.WriteLine("Takk for idag");
                    Environment.Exit(0);
                }
            }
        }

    }
    
}
