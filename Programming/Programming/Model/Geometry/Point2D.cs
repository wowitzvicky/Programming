using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о координатах геометрической фигуры.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координаты x.
        /// </summary>
        private double _x;

        /// <summary>
        /// Координаты y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задаёт координаты x. Должны быть только положительными.
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт координаты y. Должны быть только положительными.
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координаты x. Должны быть только положительными.</param>
        /// <param name="y">Координаты y. Должны быть только положительными.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}