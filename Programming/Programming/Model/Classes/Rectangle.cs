using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        public int n;
        private double _length;
        private double _width;
        private string _color;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной и/или равной 0!");
                }

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
                if (value <= 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной и/или равной 0!");
                }

                _width = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Строка цвета не может быть пустой");
                }

                _color = value;
            }
        }

        public override string ToString()
        {
            return "Rectangle " + n;
        }
        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color, int i)
        {
            _length = length;
            _width = width;
            _color = color;
            n = i;
        }
    }
}