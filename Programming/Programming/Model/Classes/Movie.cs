using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;
        
        /// <summary>
        /// Возвращает и задаёт порядковый номер фильма.
        /// </summary>
        private int id { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт длительность полёта. Должна состоять только из положительных значений.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));

                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выхода фильма. Отсчитывается с 1900 по текущий.
        /// </summary>
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(Year));

                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Отсчитывается от 0 до 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));

                _rating = value;
            }
        }
        
        /// <summary>
        /// Перегрузка.
        /// </summary>
        /// <returns>Возвращает информацию об объекте в виде строки.</returns>
        public override string ToString()
        {
            return "Movie " + id;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Длительность фильма. Состоит только из положительнрых значений.</param>
        /// <param name="year">Год выхода фильма. Отсчитывается с 1900 по текущий.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Отсчитывается от 0 до 10.</param>
        /// <param name="i">Порядковый номер фильма.</param>
        public Movie(string name, int duration, int year, string genre, double rating, int i)
        {
            Name = name;
            _duration = duration;
            _year = year;
            Genre = genre;
            _rating = rating;
            id = i;
        }
    }
}