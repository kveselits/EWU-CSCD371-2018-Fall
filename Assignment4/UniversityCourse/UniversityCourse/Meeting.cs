using System;

namespace UniversityCourse
{
	public abstract class Meeting
	{
		public string Name
		{
			get;
			set;
		}

		private DateTime[] _Schedule
		{
			get;
			set;
		}

		public virtual string _Name
		{
			get;
			set;
		}

		public DateTime ThisDayOfWeek
		{
			get;
			set;
		}

		public Meeting(DateTime[] schedule, string name)
		{
			_Schedule = schedule;
			_Name = name;
		}

		public Meeting()
		{
		}
	}
}
