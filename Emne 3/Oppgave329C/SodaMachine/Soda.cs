namespace SodaMachine
{
    internal class Soda
    {
        NameList names = new NameList();
        Random random = new Random();
        private readonly int _value;
        private readonly string _name;
        private int[] prices = new int[]{15,20,25,99};

        public Soda()
        {
            _value = GetRandomPrice();
            _name = names.GetName();
        }

        int GetRandomPrice()
        {
            int rng = random.Next(100);
            if(rng is <15) {return prices[0];}
            else if(rng is <50) {return prices[1];}
            else if(rng is <90) {return prices[2];}
            else { return prices[3];}
        }

        public string GetName()
        {
            return _name;
        }

        public int GetPrice()
        {
            return _value;
        }



    }
}
