using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы, проверяющие пересечения геометрических фигур.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, есть ли столкновение между двумя прямоугольниками.
        /// </summary>
        /// <param name="rectangle1">Первый проверяемый прямоугольник.</param>
        /// <param name="rectangle2">Второй проверяемый прямоугольник.</param>
        /// <returns>Возвращает true, если столкновение есть.
        /// И false, если столкновения нет.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                   rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                   rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Length &&
                   rectangle1.Length + rectangle1.Center.Y > rectangle2.Center.Y;
        }

        /// <summary>
        /// Проверяет, есть ли столкновение между двумя кольцами.
        /// </summary>
        /// <param name="ring1">Первое проверяемое кольцо.</param>
        /// <param name="ring2">Второе проверяемое кольцо.</param>
        /// <returns>Возвращает true, если столкновение есть.
        /// И false, если столкновения нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double hypotenuse = Math.Sqrt(dX * dX + dY * dY);
            return (hypotenuse < ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}