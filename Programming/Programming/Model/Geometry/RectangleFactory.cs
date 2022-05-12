using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.Model.Geometry
{
	public static class RectangleFactory
	{
		public static int i = 0;
		private static Random random = new Random();
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
