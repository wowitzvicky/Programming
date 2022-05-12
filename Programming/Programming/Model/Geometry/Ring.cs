using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задаёт х и у координаты.
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// Возвращает и задаёт внутренний радиус. Должен быть только положительным 
        /// и меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertMinOrMax(
                    value,
                    OuterRadius,
                    nameof(InnerRadius),
                    nameof(OuterRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт внешний радиус. Должен быть только положительным 
        /// и больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertMinOrMax(
                    InnerRadius,
                    value,
                    nameof(InnerRadius),
                    nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return ((Math.PI * OuterRadius * OuterRadius) - (Math.PI * InnerRadius * InnerRadius));
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        {
            OuterRadius = double.MaxValue;
            InnerRadius = 1;
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="innerRadius">Внутренний радиус кольца. Должен быть только положительным 
        /// и меньше внешнего радиуса.</param>
        /// <param name="outerRadius">Внешний радиус кольца. Должен быть только положительным 
        /// и больше внутреннего радиуса.</param>
        /// <param name="x">Координаты x. Должны быть только положительными.</param>
        /// <param name="y">Координаты у. Должны быть только положительными.</param>
        public Ring(double innerRadius, double outerRadius, double x, double y)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            Center = new Point2D(x, y);
        }
    }
}