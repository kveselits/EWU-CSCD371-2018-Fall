using System;

namespace UniversityCourse
{
	public class Event : Meeting
	{
	    private DateTime _ScheduleItem = default(DateTime);
        public string ScheduleTimeOfDay
	    {
            get => $"{_ScheduleItem.TimeOfDay}";
            set
	        {
	            if (Double.TryParse(value, out double hours))
	            {
	                try
	                {
	                    _ScheduleItem = _ScheduleItem.AddHours(hours);
	                }
	                catch (ArgumentOutOfRangeException ex)
	                {
	                    throw new ArgumentOutOfRangeException(nameof(value));
	                }
	            }
	        }
	    }
        public string ScheduleDayOfWeek
		{
			get => $"{_ScheduleItem.DayOfWeek}";
		    set
			{
			    _ScheduleItem = default(DateTime);

                switch (value)
				{
                case "monday":
					break;
				case "tuesday":
				    _ScheduleItem = _ScheduleItem.AddDays(1);
                        break;
				case "wednesday":
				    _ScheduleItem = _ScheduleItem.AddDays(2);
                        break;
				case "thursday":
				    _ScheduleItem = _ScheduleItem.AddDays(3);
                        break;
				case "friday":
				    _ScheduleItem = _ScheduleItem.AddDays(4);
                        break;
				case "saturday":
				    _ScheduleItem = _ScheduleItem.AddDays(5);
                        break;
				case "sunday":
				    _ScheduleItem = _ScheduleItem.AddDays(6);
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
			return $"{_ScheduleItem.DayOfWeek} {_ScheduleItem.TimeOfDay} {_Name}";
		}
	}
}
