using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Model.Classes
{
	public static class Validator
	{

		public static void AssertValueInRange(string text)
		{
			if (text.Length>100&&text.Length<1)
			{
				throw new ArgumentException("Название должно входить в допустимый диапазон");
			}
		}

	}
}
