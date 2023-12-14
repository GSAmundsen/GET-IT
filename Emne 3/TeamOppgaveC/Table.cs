namespace TeamOppgaveC
{
    internal class Table
    {
        private string _name;
        private int _chairs;
        private bool _isBooked;
        private DateTime _bookingStartTime;
        private DateTime _bookingEndTime;

        public Table(string name, int chairs)
        {

            _name = name;
            _chairs = chairs;
            _isBooked = false;

            DateTime today = DateTime.Now;
            _bookingStartTime = new DateTime(today.Year, today.Month, today.Day, 16, 0, 0);
                //todays date +1 year
            _bookingEndTime = new DateTime(today.Year+1, today.Month, today.Day, 20, 0, 0);

        }

        public int GetChairs()
        {
            return _chairs;
        }

        public bool IsBooked(DateTime dtime)
        {
            if (_isBooked) {return _isBooked;}

            _isBooked = !(dtime >= _bookingStartTime && dtime.AddHours(2) <= _bookingEndTime);
            
            return _isBooked;
        }


        public void BookTable(DateTime dtime) {
            _bookingStartTime = dtime; 
            _bookingEndTime = dtime.AddHours(2);
            _isBooked= true;
        }

        public string GetDescription()
        {
            return $"Bord {_name} har plass til {_chairs} personer";
        }

        public string GetTableName()
        {
            return _name;
        }
    }
}
