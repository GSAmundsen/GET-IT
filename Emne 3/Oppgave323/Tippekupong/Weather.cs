namespace Tippekupong
{
    internal class Weather
    {
        public string weatherType { get; private set; }
        public float weatherPenalty { get; private set; }


        public Weather(string type, float penalty) {
            weatherType = type;
            weatherPenalty = penalty;  
        
        }
    }
}
