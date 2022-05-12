using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для проверки введённых значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет на положительное значение введённое целое число.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если введено отрицательное значение.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"В {propertyName} должны быть введены положительные значения");
            }
        }
        
        /// <summary>
        /// Проверяет на положительное значение введённое вещественное число.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если введено отрицательное значение.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"В {propertyName} должны быть введены положительные значения");
            }
        }

        /// <summary>
        /// Проверяет, входит ли целочисленное значение в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если введено значение вне заданного диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (!(value >= min) || !(value <= max))
            {
                throw new ArgumentException($"Значение в {propertyName} должно соответствовать диапазону");
            }
        }
        
        /// <summary>
        /// Проверяет, входит ли вещественное значение в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если введено значение вне заданного диапазона.</exception>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (!(value >= min) || !(value <= max))
            {
                throw new ArgumentException($"Значение в {propertyName} должно соответствовать диапазону");
            }
        }

        /// <summary>
        /// Проверяет, меньше ли минимальное значение максимального.
        /// </summary>
        /// <param name="min">Меньшее значение.</param>
        /// <param name="max">Большее значение.</param>
        /// <param name="propertyName1">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <param name="propertyName2">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если минимальное введённое значение
        /// оказывается больше максимального.</exception>
        public static void AssertMinOrMax(double min, double max, string propertyName1, string propertyName2)
        {
            if (min > max)
            {
                throw new ArgumentException($"{propertyName1} не может быть больше {propertyName2}");
            }
        }
    }
}