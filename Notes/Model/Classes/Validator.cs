using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Model.Classes
{
	/// <summary>
	/// Предоставляет методы для проверки введённых значений.
	/// </summary>
	public static class Validator
	{
		/// <summary>
		/// Проверяет, что строка состоит из меньше чем 100 символов.
		/// </summary>
		/// <param name="text">Проверяемая строка.</param>
		/// <exception cref="ArgumentException">Появляется, если длина строки больше 100 символов.</exception>
		public static void AssertValueInRange(string text)
		{
			if (text.Length>100&&text.Length<1)
			{
				throw new ArgumentException("Название должно входить в допустимый диапазон");
			}
		}

	}
}
