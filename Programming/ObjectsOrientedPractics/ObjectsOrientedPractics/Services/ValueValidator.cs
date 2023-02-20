using System;

namespace ObjectsOrientedPractics.Services
{
    /// <summary>
    /// Статический класс для проверки значений.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки находится в пределах максимального значения. 
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <param name="maxLength">Значение максимальной длины.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Возникает, если длина строки больше максимального значения.</exception>
        public static void AssertStringOnLength(string str, int maxLength, string propertyName)
        {
            if (str == null)
            {
                return;
            }
            if (str.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} length > {maxLength}");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное число находится в пределах минимального и максимального значений. 
        /// </summary>
        /// <param name="value">Исходное значение.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Возникает, если значение находится
        /// вне пределов минимального и максимального значений.</exception>
        public static void AssertOnPositiveValue(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"{propertyName} < {min} or {propertyName} > {max}: {value}");
        }
    }
}