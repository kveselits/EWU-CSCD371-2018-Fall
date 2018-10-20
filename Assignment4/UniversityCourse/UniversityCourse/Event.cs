using System;

namespace UniversityCourse
{
	public class Event : Meeting
	{
		public string ScheduleTimeOfDay
		{
			get;
			set;
		}

		public DateTime _ScheduleDayOfWeek
		{
			get;
			set;
		}

		public string ScheduleDayOfWeek
		{
			get
			{
				return $"{_ScheduleDayOfWeek}";
			}
			set
			{
				DateTime scheduleDayOfWeek = default(DateTime);
				switch (value)
				{
				case "monday":
					_ScheduleDayOfWeek = scheduleDayOfWeek;
					break;
				case "tuesday":
					_ScheduleDayOfWeek = scheduleDayOfWeek.AddDays(1.0);
					break;
				case "wednesday":
					_ScheduleDayOfWeek = scheduleDayOfWeek.AddDays(2.0);
					break;
				case "thursday":
					_ScheduleDayOfWeek = scheduleDayOfWeek.AddDays(3.0);
					break;
				case "friday":
					_ScheduleDayOfWeek = scheduleDayOfWeek.AddDays(4.0);
					break;
				case "saturday":
					_ScheduleDayOfWeek = scheduleDayOfWeek.AddDays(5.0);
					break;
				case "sunday":
					_ScheduleDayOfWeek = scheduleDayOfWeek.AddDays(6.0);
					break;
				}
			}
		}

		public Event()
		{
		}

		public Event(string dayOfWeek, string timeOfDay)
			: this(dayOfWeek, timeOfDay, "default")
		{
		}

		public Event(string dayOfWeek, string timeOfDay, string name)
		{
			ScheduleDayOfWeek = dayOfWeek;
			ScheduleTimeOfDay = timeOfDay;
			base.Name = name.Trim().ToLower();
		}

		public override string ToString()
		{
			return $"{_ScheduleDayOfWeek.DayOfWeek} {_ScheduleDayOfWeek.TimeOfDay} {_Name}";
		}
	}
}
