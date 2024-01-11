namespace IntroClasses
{
    class Suspects
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public string County { get; private set; }

        static Suspects[] suspects = new Suspects[]
        {
            //Data provided by ChatGPT
            new Suspects("Emma" , "Hansen", 28, "Female", "Oslo" ),
            new Suspects("Liam" , "Olsen", 35, "Male","Akershus" ),
            new Suspects("Nora" , "Berg", 42, "Female", "Hordaland"),
            new Suspects("Elias" , "Johansen", 19, "Male", "Rogaland"),
            new Suspects("Ingrid","Nygaard", 31, "Female", "Trøndelag"),
            new Suspects("Oliver","Nygaard", 50, "Male", "Vestfold"),
            new Suspects("Mia", "Sørensen", 26, "Female", "Troms"),
            new Suspects("William","Olsen", 39, "Male", "Finnmark"),
            new Suspects("Sophie", "Larsen", 44, "Female", "Sogn og Fjordane"),
            new Suspects("Lucas" , "Kristiansen", 22, "Male", "Oppland"),
            new Suspects("Ella" , "Hermansen", 29, "Female", "Vest-Agder"),
            new Suspects("Oscar" , "Larsen", 37, "Male", "Østfold"),
            new Suspects("Eva" , "Pedersen", 33, "Female", "Nord-Trøndelag"),
            new Suspects("Eva", "Pedersen", 33, "Female", "Nord-Trøndelag"),
            new Suspects("Alexander", "Knutsen", 48, "Male", "Vest-Agder"),
            new Suspects("Isabella", "Andreassen", 29, "Female", "Telemark"),
            new Suspects("Noah", "Holm", 36, "Male", "Nordland"),
            new Suspects("Aurora", "Solberg", 27, "Female", "Møre og Romsdal"),
            new Suspects("Gabriel", "Haugen", 41, "Male", "Buskerud"),
            new Suspects("Maja", "Jensen", 24, "Female", "Østfold"),
            new Suspects("Sebastian", "Berg", 40, "Male", "Sogn og Fjordane"),
            new Suspects("Astrid", "Vik", 32, "Female", "Hedmark"),
            new Suspects("Lukas", "Sørensen", 45, "Male", "Aust-Agder")


        };

        public Suspects(string fName, string lName, int age, string gender, string county)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;  
            Gender = gender;    
            County = county;    
        }

        public static void PrintAllSuspects()
        {
            foreach(Suspects s in suspects)
            {
                Console.WriteLine($"First name: {s.FirstName} \nLast name: {s.LastName} \nAge:{s.Age}\nGender: {s.Gender}\nCounty: {s.County}\n----------");

            }
        }

        public static void SelectByName(string name)
        {
            Console.WriteLine("Searching by matching first name, or last name...");
            int count = 0;
            foreach (Suspects s in suspects)
            {
                if(name.ToLower() == s.FirstName.ToLower() || name == s.LastName.ToLower())
                {
                    Console.WriteLine($"\nMatch found: \nFirst name: {s.FirstName} \nLast name: {s.LastName} \nAge:{s.Age}\nGender: {s.Gender}\nCounty: {s.County}\n----------");
                    count++;
                }
            }

            Console.WriteLine(count == 0 ? "No matches found" : $"{count} match(es) found");

        }

    }
}
