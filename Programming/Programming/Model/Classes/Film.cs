using System;

namespace Programming.Model.Classes
{
    public class Film
    {
        public int n;
        private string _name;
        private int _duration;
        private int _year;
        private string _genre;
        private double _rating;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Строка названия не может быть пустой");
                }

                _name = value;
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Строка жанра не может быть пустой");
                }

                _genre = value;
            }
        }

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
                    throw new ArgumentException("Фильм не может длиться 0 или меньше минут.");
                }

                _duration = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1900 || value > 2022)
                {
                    throw new ArgumentException("Год должен начинаться с 1900 и не превышать текущий 2022");
                }

                _year = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Рейтинг должен быть от 0 до 10");
                }

                _rating = value;
            }
        }
        
        public override string ToString()
        {
            return "Film " + n;
        }

        public Film()
        {
        }

        public Film(string name, int duration, int year, string genre, double rating, int i)
        {
            _name = name;
            _duration = duration;
            _year = year;
            _genre = genre;
            _rating = rating;
            n = i;
        }
    }
}