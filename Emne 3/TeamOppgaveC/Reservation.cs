
namespace TeamOppgaveC
{
    internal class Reservation
    {
        private string _name;
        private string _phoneNumber;
        private int _guests;
        private DateTime _reservationTime;
        private string _description;
        private bool _isBooked;


        public Reservation(string resName, string resPhoneN, int guests, DateTime resTime) 
        {
            _name = resName;
            _phoneNumber = resPhoneN;
            _guests = guests;
            _reservationTime = resTime;
            // Default description, fram til en booking lykkes.
            _description = $"Vi beklager! Det er ikke ledig bord til {_guests} personer {_reservationTime:dd.MM.yyyy} kl. {_reservationTime:HH:mm}";
        
        }

        public string GetDescription() { 
            return _description; 
        }


        public void SetDescription(int guests, DateTime dtime)
        {
            _guests = guests;
            _reservationTime = dtime;
            _description = $"Reservert bord til {_guests} personer {_reservationTime:dd.MM.yyyy} kl. {_reservationTime:HH:mm}";
            _isBooked = true;

        }

        public Reservation GetReservation() 
        {
            // Om denne reservasjonen ikke førte til en booking, feks pga ingen ledige bord eller tid:
            // returner null, ellers, returner dette objektet.
            if(!_isBooked) { return null; }
            return this;
        }
    }
}
