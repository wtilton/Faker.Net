using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class Number
	{
		private static readonly Random r = new Random();

		public static int Between(int min, int max)
		{
			return r.Next(min, max);
		}

		public static int Below(int max)
		{
			return r.Next(max);
		}
	}
}
