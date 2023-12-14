namespace SodaMachine
{
    internal class NameList
    {
        Random random = new Random();
        private int retrievedCounter;
        private List<string> _names = new List<string>()
        {
            "Runesteinbruser Ragnarøk",
            "Yggdrasil Ypperbrus",
            "Valhallavann Valora",
            "Skjoldmøs Sjøsprett",
            "Midgardsbrus Mjølktåke",
            "Odinsskum Ølve",
            "Valkyriebølge Valhallafløt",
            "Huginn & Muninn Myntebrus",
            "Berserkerbrus Bjørnebrus",
            "Thorstrek Tordenbrus",
            "Nanoenergi Blast",
            "Kunstig Intelligensa Fizz",
            "CyberSjokk Sydeksitement",
            "Androida-Økotone",
            "Quantum Glimmergaz",
            "Neon Nimbus Brisk",
            "Tekno-Taurin Turbocharge",
            "Synthwave Sparklesplash",
            "Elektrisk Euforia Eksos",
            "Fremtidens Funky Friskhet"
        };
        
        public NameList() {
            ListRandomizer();
        }

        public string GetName()
        {
            if(retrievedCounter < _names.Count) { 
                return _names[retrievedCounter++];
            }
            return "OUT OF ORDER!";
        }

        void ListRandomizer()
        {
            int n = _names.Count;
            while (n > 0)
            {
                n--;
                int k = random.Next(n+1); // If length = 20, random number between 0-20
                string value = _names[k]; // Store the name at the random index in a temp var
                _names[k] = _names[n]; // Set the name at the random index to the n value (list count -1 pr iteration)
                _names[n] = value; // Set the name of the n index to the temp stored value.
            }
        }
    }
}
