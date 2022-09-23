namespace ObjectsOrientedPractics.Services
{
    /// <summary>
    /// Сервисный статический класс. Генерирует целочисленные идентификаторы.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Cтатическое поле-счётчик.
        /// </summary>
        private static int _count;
        
        /// <summary>
        /// Статическая фабрика, генерирующая целочисленный идентификатор.
        /// </summary>
        /// <returns></returns>
        public static int GetNextId()
        {
            return _count++;
        }
    }
}