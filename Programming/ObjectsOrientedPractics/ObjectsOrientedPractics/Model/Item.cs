﻿using ObjectsOrientedPractics.Services;

namespace ObjectsOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект "Товар".
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Хранит имя товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит информацию о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Хранит цену товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает или задаёт значение имени. Длина строки не должна превышать 200./>
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает или задает знаяение поля информации. Длина строки не должна превышать 1000./>
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение цены. Длина строки должна быть в пределах от 0 до 100000./>
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertOnPositiveValue(value, 0, 100000, nameof(Name));
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр объекта <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Цена товара.</param>
        public Item(string name, string info, double cost)
        {
            Id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        public Item()
        {
            Id = IdGenerator.GetNextId();
        }

        public override string ToString()
        {
            return $"{nameof(Item)}-{Id + 1}";
        }
    }
}