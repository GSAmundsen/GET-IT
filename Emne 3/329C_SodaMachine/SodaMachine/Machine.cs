using System.Security.AccessControl;
using System.Text;

namespace SodaMachine
{
    internal class Machine
    {
        private List<Soda> _sodas = new List<Soda>();
        private int sodasCount = 5;
        private int retrievedCount;

        public Machine() { 
            
            for (int i = 0; i < sodasCount; i++)
            {
                var soda = new Soda();
                _sodas.Add(soda);

            }
        }

        public string ReturnContents()
        {
            var result = new StringBuilder();
            foreach(Soda s in  _sodas)
            {
                result.Append("\n"+s.GetName()+" - "+s.GetPrice()+"kr");
            }
            return result.ToString();
        }

    }
}
