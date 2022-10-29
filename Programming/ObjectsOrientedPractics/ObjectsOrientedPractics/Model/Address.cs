using ObjectsOrientedPractics.Services;

namespace ObjectsOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект Адрес.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс. Шестизначное число.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион. Не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город(населённый пункт). Не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица. Не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома. Не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения. Не более 10 символов.
        /// </summary>
        private string _apartment;

        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertOnPositiveValue(value, 0, 999_999, nameof(Index));
                _index = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        public Address()
        {
        }

        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}