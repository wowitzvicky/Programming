using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        public static int _allRectanglesCount;
        
        private double _length;
        
        private double _width;
        
        public string Color { get; set; }
        
        public int Id { get; private set; }
        
        public Point2D Center { get; set; }

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
        public override string ToString()
        {
            return "Rectangle " + Id;
        }
        public Rectangle()
        {
        }

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