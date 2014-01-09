using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class Date
	{
		public enum DateType
		{
			Days, Minutes, Hours, Months
		}

		public static DateTime Past(int maxAgo, DateType type = DateType.Days)
		{
			return GiveDate(-Number.Below(maxAgo), type);
		}

		public static DateTime Past(int minAgo, int maxAgo, DateType type = DateType.Days)
		{
			return Between(-Number.Below(minAgo), -Number.Below(maxAgo), type);
		}

		public static DateTime Future(int max, DateType type = DateType.Days)
		{
			return GiveDate(Number.Below(max), type);
		}

		public static DateTime Future(int min, int max, DateType type = DateType.Days)
		{
			return Between(min, max, type);
		}

		private static DateTime GiveDate(int amount, DateType type)
		{
			switch (type)
			{
				case DateType.Months:
					return DateTime.Now.AddMonths(amount);
				case DateType.Minutes:
					return DateTime.Now.AddMinutes(amount);
				case DateType.Hours:
					return DateTime.Now.AddHours(amount);
				default:
					return DateTime.Now.AddDays(amount);
			}
		}

		public static DateTime Between(int min, int max, DateType type = DateType.Days)
		{
			return Between(GiveDate(min, type), GiveDate(max, type));
		}

		public static DateTime Between(DateTime first, DateTime last)
		{
			TimeSpan span = last - first;
			var numberOfDays = Convert.ToInt32(span.TotalDays);
			return first.AddDays(Number.Below(numberOfDays));
		}
	}
}
