using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Длительность песни.
        /// </summary>
        private int _duration;
        
        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт исполнителя песни.
        /// </summary>
        public string Author { get; set; }
        

        /// <summary>
        /// Возвращает и задаёт длительность песни. Должна состоять только из положительных значений.
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
        /// Создаёт экземпляр класса <see cref="Song"/>
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="author">Исполнитель.</param>
        /// <param name="duration">Длительность песни. Состоит только из положительных значений.</param>
        public Song(string name, string author, int duration)
        {
            Name = name;
            Author = author;
            _duration = duration;
        }
    }
}