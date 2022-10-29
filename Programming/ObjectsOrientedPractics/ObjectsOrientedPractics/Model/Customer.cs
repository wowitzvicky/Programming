using ObjectsOrientedPractics.Services;

namespace ObjectsOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект "Покупатель".
    /// </summary>
    public class Customer
    {
        public const int MaxLengthFullname = 200;
        public const int MaxLengthAddress = 500;

        /// <summary>
        /// Хранит полное имя <see cref="Customer"/>.
        /// </summary>
        private string _fullname;

        /// <summary>
        ///  Возвращает или задаёт адрес <see cref="Customer"/>.
        /// </summary>
        public Address Address { get; set; }
        
        /// <summary>
        /// Возвращает значение иденитфикатора.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает или задаёт значение полного имени. Длина строки не должна превышать <see cref="MaxLengthFullname"/>/>
        /// </summary>
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxLengthFullname, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр объекта <see cref="Customer"/> .
        /// </summary>
        /// <param name="fullname">Значение полного имени.</param>
        /// <param name="address">Значение адреса.</param>
        public Customer(string fullname, string address)
        {
            Id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = new Address();
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Customer()
        {
            Id = IdGenerator.GetNextId();
        }
        
        public override string ToString()
        {
            return $"{nameof(Customer)}-{Id + 1}";
        }
    }
}