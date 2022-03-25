using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name { set; get; }
        private string _lastname { set; get; }
        private string _number;

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер должен состоять из 11 цифр");
                }

                if (long.TryParse(value, out long num) == false)
                {
                    throw new ArgumentException("Номер должен состоять из цифр");
                }

                _number = value;
            }
        }

        public Contact()
        {
        }

        public Contact(string name, string lastname, string number)
        {
            _name = name;
            _lastname = lastname;
            _number = number;
        }
    }
}