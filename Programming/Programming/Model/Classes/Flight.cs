using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _departure { set; get; }
        private string _destination { set; get; }
        private int _time;

        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение времени не может быть отрицательным и/или равным 0!");
                }

                _time = value;
            }
        }

        public Flight()
        {
        }

        public Flight(string departure, string destination, int time)
        {
            _departure = departure;
            _destination = destination;
            _time = time;
        }
    }
}