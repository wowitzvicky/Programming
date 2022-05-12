using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полёте.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _time;
        
        /// <summary>
        /// Возвращает и задаёт место вылета.
        /// </summary>
        public string Departure { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт пункт назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт время в минутах. Должно состоять только из положительных значений.
        /// </summary>
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Time));
                _time = value;
            }
        }

        /// <summary>
        /// Создаёт экзмепляр класса <see cref="Flight"/>
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="departure">Место вылета.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="time">Время в минутах. Должно состоять только из положительных значений.</param>
        public Flight(string departure, string destination, int time)
        {
            Departure = departure;
            Destination = destination;
            _time = time;
        }
    }
}