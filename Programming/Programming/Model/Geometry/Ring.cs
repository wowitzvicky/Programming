using System;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _innerRadius;

        private double _outerRadius;
        
        public Point2D Center { get; private set; }

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

        public double Area
        {
            get
            {
                return ((Math.PI * OuterRadius * OuterRadius) - (Math.PI * InnerRadius * InnerRadius));
            }
        }

        public Ring()
        {
            OuterRadius = double.MaxValue;
            InnerRadius = 1;
        }

        public Ring(double innerRadius, double outerRadius, double x, double y)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            Center = new Point2D(x, y);
        }
    }
}