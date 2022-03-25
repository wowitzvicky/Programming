using System;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _name { set; get; }
        private int _mark;
        private string _teacher { set; get; }

        private int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value <= 0 || value > 5)
                {
                    throw new ArgumentException("Некорректная оценка");
                }

                _mark = value;
            }
        }

        public Discipline()
        {
        }

        public Discipline(string name, int mark, string teacher)
        {
            _name = name;
            _mark = mark;
            _teacher = teacher;
        }
    }
}