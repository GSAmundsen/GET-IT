//Implementer en brusautomat. Ulike drikker har ulik pris. Automaten har en lagerbeholdning.
//Man kan putte på mynter (1kr, 5kr, 10kr, 20kr). Man trykker på en knapp for en bestemt drikk -
//hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
//Det finnes en knapp for å få gjeldende saldo tilbake.


namespace SodaMachine
{
    internal class Program
    {
        static Wallet wallet = new Wallet(6, 15, 20, 40);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Du har {wallet.GetAmount()}kr i lommeboken.\n" +
                    $"1 - 1kr\n" +
                    $"2 - 5kr\n" +
                    $"3 - 10kr\n" +
                    $"4 - 20kr\n" +
                    $"Hvor mye ønsker du å legge på maskinen? Eller trykk ENTER for å avbryte");
                var inp = Console.ReadLine();
                if(inp is "")
                {
                    Console.WriteLine("Takk for idag");
                    Environment.Exit(0);
                }
            }
            
        }
    }
}
