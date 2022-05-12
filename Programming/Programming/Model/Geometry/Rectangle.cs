using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        public static int _allRectanglesCount;
        
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;
        
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;
        
        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор.
        /// </summary>
        public int Id { get; private set; }
        
        /// <summary>
        /// Возвращает и задаёт х и у координаты.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
            private set
            {
                _allRectanglesCount = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Должна только быть положительной.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должна только быть положительной.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Перегрузка.
        /// </summary>
        /// <returns>Возвращает информацию об объекте в виде строки.</returns>
        public override string ToString()
        {
            return "Rectangle " + Id;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть только положительной.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть только положительной.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="i">Уникальный идентификатор.</param>
        /// <param name="x">Координаты х. Должны быть только положительными.</param>
        /// <param name="y">Координаты y. Должны быть только положительными.</param>
        public Rectangle(double length, double width, string color, int i, double x, double y)
        {
            _length = length;
            _width = width;
            Color = color;
            AllRectanglesCount++;
            Id = AllRectanglesCount;
            Center = new Point2D(x, y);
        }
    }
}