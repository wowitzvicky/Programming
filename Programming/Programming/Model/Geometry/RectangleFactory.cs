using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.Model.Geometry
{
	/// <summary>
	/// Предоставляет методы для создания объектов класса Rectangle.
	/// </summary>
	public static class RectangleFactory
	{
		/// <summary>
		/// Уникальный идентификатор.
		/// </summary>
		public static int i = 0;

		/// <summary>
		/// Генерирует случайные значения.
		/// </summary>
		private static Random random = new Random();

		/// <summary>
		/// Создаёт объект класса Rectangle со случайными значениями.
		/// </summary>
		/// <returns>Возвращает объект класса Rectangle.</returns>
		static public Rectangle Randomize()
		{
			
			return new Rectangle
				(random.Next(1, 100),
					random.Next(1, 100),
					"White",
					i++,
					random.Next(1,260),
					random.Next(1, 300)
				); 
		}
	}
}
