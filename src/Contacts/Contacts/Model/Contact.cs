using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model
{
    /// <summary>
    /// Представляет объект "Контакт".
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Хранит имя <see cref="Contact"/>.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит номер телефона <see cref="Contact"/>.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит адрес электронной почты <see cref="Contact"/>.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает или задаёт значение имени.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт номер мобильного телефона.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт адрес электронной почты.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр объекта <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Значение имени.</param>
        /// <param name="phoneNumber">Значение номера мобильного телефона.</param>
        /// <param name="email">Значение адреса электронной почты.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            Name = "Default name";
            PhoneNumber = "";
            Email = "";
        }
    }
}