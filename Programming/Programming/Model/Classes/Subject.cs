using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные об учебной дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;
        
        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт преподавателя дисциплины.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Должна отсчитываться от 1 до 5.
        /// </summary>
        private int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Mark));
                _mark = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Возвращает и задаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="mark">Оценка по дисциплине. Отсчитывается от 1 до 5.</param>
        /// <param name="teacher">Преподаватель дисциплины.</param>
        public Subject(string name, int mark, string teacher)
        {
            Name = name;
            _mark = mark;
            Teacher = teacher;
        }
    }
}