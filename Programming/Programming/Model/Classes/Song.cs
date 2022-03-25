using System;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string _name { get; set; }
        private string _author { get; set; }
        private int _duration;

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Песня не может длиться 0 или меньше минут");
                }

                _duration = value;
            }
        }

        public Song()
        {
        }

        public Song(string name, string author, int duration)
        {
            _name = name;
            _author = author;
            _duration = duration;
        }
    }
}