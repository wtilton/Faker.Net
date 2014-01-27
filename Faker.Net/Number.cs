using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class Number
	{
		private static readonly Random r = new Random();
		private static readonly object syncLock = new object();

		public static int Between(int min, int max)
		{
			lock (syncLock)
			{
				return r.Next(min, max);
			}
		}

		public static double Between(double min, double max)
		{
			lock (syncLock)
			{
				return min + (r.NextDouble() * (max - min));
			}
		}

		public static int Below(int max)
		{
			lock (syncLock)
			{
				return r.Next(max);
			}
		}
	}
}
